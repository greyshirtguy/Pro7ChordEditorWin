using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using Google.Protobuf;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Rv.Data;
using static Rv.Data.Action;
using static Rv.Data.NetworkAPI_v1.Types.API_v1_Presentation_Request.Types;
using Presentation = Rv.Data.Presentation;
using static Rv.Data.NetworkAPI_v1.Types.API_v1_Trigger_Request.Types;
using System.Text.RegularExpressions;
using System.Reflection;
using static Rv.Data.Graphics.Types.Text.Types.Attributes.Types;
using Paragraph = System.Windows.Documents.Paragraph;
using static Rv.Data.Template.Types;
using static Rv.Data.MusicKeyScale.Types;
using static Rv.Data.PlaylistItem.Types;
using System.Diagnostics;
using System.Runtime.Remoting.Contexts;

namespace Pro7ChordEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Pro7Presentation selectedPro7Presentation;
        private List<Pro7Library> pro7Libraries;
        private List<Pro7Presentation> pro7Presentations;
        private List<MusicKeyScale> musicKeyScales;
        private string logPath;

        Rv.Data.Presentation presentation;

        public List<Pro7Library> Pro7Libraries
        {
            get { return pro7Libraries; }
        }

        public List<Pro7Presentation> Pro7Presentations
        {
            get { return pro7Presentations; }
        }

        public MainWindow()
        {
            InitializeComponent();
            logPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            mainWindow.Title = mainWindow.Title + " (" + Assembly.GetExecutingAssembly().GetName().Version + ")";
            addLog(mainWindow.Title + " started");

            // Quick and rough way to build combobox list of all keys/scale without proper data binding/MVVM....
            musicKeyScales = new List<MusicKeyScale>();
            foreach (MusicKey key in Enum.GetValues(typeof(MusicKeyScale.Types.MusicKey)))
            {
                foreach (MusicScale scale in Enum.GetValues(typeof(MusicKeyScale.Types.MusicScale)))
                {
                    // Keep a reference list of MusicKeyScale objects for easy lookup/conversion from selected combobox items...
                    MusicKeyScale musicKeyScale = new MusicKeyScale();
                    musicKeyScale.MusicKey = key;
                    musicKeyScale.MusicScale = scale;
                    musicKeyScales.Add(musicKeyScale);

                    if (scale == MusicScale.Minor)
                    {
                        cboOriginalKey.Items.Add(key.ToString().Replace("Flat", "b").Replace("Sharp", "#") + " Min");
                        cboUserKey.Items.Add(key.ToString().Replace("Flat", "b").Replace("Sharp", "#") + " Min");
                    }
                    else
                    {
                        cboOriginalKey.Items.Add(key.ToString().Replace("Flat", "b").Replace("Sharp", "#"));
                        cboUserKey.Items.Add(key.ToString().Replace("Flat", "b").Replace("Sharp", "#"));
                    }
                }
            }

            string pro7SystemFolder;  // Default = %USERPROFILE%\Documents\ProPresenter but it can be customised/moved in Preferences...

            // Check if Pro7 system folder has been moved/customised...
            string customPathSettingsFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\RenewedVision\\ProPresenter\\PathSettings.proPaths";
            if (File.Exists(customPathSettingsFilePath))
            {
                try
                {
                    using (var sr = new StreamReader(customPathSettingsFilePath))
                    {
                        pro7SystemFolder = Regex.Match(sr.ReadToEnd().Replace(@"\\", @"\"), @"(?<=Base=).*(?=;)").Value;
                        addLog("Pro7 System Folder In Custom Location: " + pro7SystemFolder);
                    }
                }
                catch (IOException e)
                {
                    addLog("Exception " + e.Message + " while trying to read PathSettings.proPaths");
                    MessageBox.Show("Exception " + e.Message + " while trying to read PathSettings.proPaths");
                    return;
                }
            }
            else
            {
                pro7SystemFolder = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ProPresenter\\");
                addLog("Assuming pro7SystemFolder=" + pro7SystemFolder);
            }

            // Create list to store all Libraries found 
            pro7Libraries = new List<Pro7Library>();

            if (Directory.Exists(pro7SystemFolder + "Libraries"))
            {
                foreach (string libraryFolder in Directory.EnumerateDirectories(pro7SystemFolder + "Libraries"))
                {
                    addLog("Adding library folder: " + libraryFolder);
                    pro7Libraries.Add(new Pro7Library { Name = System.IO.Path.GetFileName(libraryFolder), Path = libraryFolder });
                }
            }
            else
            {
                addLog(pro7SystemFolder + "Libraries not found");
                MessageBox.Show(pro7SystemFolder + "Libraries not found.\n\n**Make sure Pro7 installed before using this app**");
                this.Close(); // quit app - no library folders found!
            }

            this.DataContext = this;
        }

        private void addLog(string logMessage)
        {
            if (!Directory.Exists(logPath))
                logPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string logFileName = logPath + @"\Pro7ChordEditor.log";

            try
            {
                if (!File.Exists(logFileName))
                    File.CreateText(logFileName);

                StreamWriter sw = File.AppendText(logFileName);
                sw.WriteLine(DateTime.Now + " - " + logMessage);
                sw.Close();
            }
            catch (Exception ex)
            {
                // TODO:
            }
        }

        private void loadPresentation(string presentationPath)
        {
            stackPanel.Children.Clear();
            using (var input = File.OpenRead(presentationPath))
            {
                addLog("Parsing presentation: " + presentationPath);
                try
                {
                    presentation = Rv.Data.Presentation.Parser.ParseFrom(input);
                    if (presentation.MultiTracksLicensing != null)
                    {
                        TextBlock tb = new TextBlock();
                        tb.FontSize = 24;
                        tb.IsEnabled = false;
                        tb.TextWrapping = TextWrapping.Wrap;
                        tb.Text = "This is a MultiTracks document." + Environment.NewLine + "The license agreement between RV & MT does not allow RV to offer editing in Pro7." + Environment.NewLine + Environment.NewLine + "For now, until I learn more...To keep this app safe from any legal issues (or getting on the bad side of any big company), editing MT documents is disabled in this app as well.";
                        stackPanel.Children.Add(tb);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    addLog("Exception: " + ex.Message + " during parsing");
                }

                try
                {
                    // Get string representation of original key
                    string originalKey = presentation.Music.Original.MusicKey.ToString();
                    if (presentation.Music.Original.MusicScale == MusicScale.Minor)
                        originalKey += " Min";

                    // Select matching original key on cboOriginalKey
                    cboOriginalKey.SelectedIndex = cboOriginalKey.Items.IndexOf(originalKey);

                    // Get string representation of user key
                    string userKey = presentation.Music.User.MusicKey.ToString();
                    if (presentation.Music.User.MusicScale == MusicScale.Minor)
                        userKey += " Min";

                    // Select matching user key on cboUserKey
                    cboUserKey.SelectedIndex = cboUserKey.Items.IndexOf(userKey);
                }
                catch (Exception ex)
                {
                    addLog("Exception " + ex.Message + " while trying to determine original and user key.");
                }

                foreach (Rv.Data.Cue cue in presentation.Cues)
                {
                    addLog("Processing Cue: " + cue.Name);
                    foreach (Rv.Data.Action action in cue.Actions)
                    {
                        if (action.ActionTypeDataCase == ActionTypeDataOneofCase.Slide)
                        {
                            addLog("Processing Action: " + action.Type);
                            // Create a new RichTextBox for each slide (and setup basic properties and events to give desired edit behaviour)
                            RichTextBox richTextBox = new RichTextBox();
                            richTextBox.FontSize = 40;
                            richTextBox.Background = Brushes.LightGray;
                            richTextBox.Padding = new Thickness(0, 10, 0, 10);
                            richTextBox.PreviewKeyDown += RichTextBox_PreviewKeyDown;
                            richTextBox.PreviewTextInput += RichTextBox_PreviewTextInput;

                            // TODO: Consider instead to enumerate and find first slide element with user text
                            // foreach (Rv.Data.Slide.Types.Element slideElement in action.Slide.Presentation.BaseSlide.Elements)
                            if (action.Slide.Presentation.BaseSlide.Elements.Count > 0)
                            {
                                // Load text....
                                Rv.Data.Slide.Types.Element slideElement = action.Slide.Presentation.BaseSlide.Elements[0];
                                addLog("Processing text from first slide element: " + slideElement.Element_.Name);
                                MemoryStream stream = new MemoryStream(ASCIIEncoding.Default.GetBytes(slideElement.Element_.Text.RtfData.ToStringUtf8()));
                                TextRange range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                                range.Load(stream, DataFormats.Rtf);
                                range.ClearAllProperties();

                                // Convert RTF to plain text (with no spacing between lines/paragraphs)
                                String plainText = range.Text;
                                addLog("Text: " + plainText);
                                richTextBox.Document.Blocks.Clear();
                                richTextBox.AppendText(plainText);
                                foreach (var block in richTextBox.Document.Blocks)
                                {
                                    block.Margin = new Thickness(0);
                                }

                                // I know.. this is a very crude way to make a UI element that is linked to data that is edits...but it's good for a quick demo.
                                richTextBox.Tag = slideElement;

                                // Load Chords into a list...
                                addLog("Loading Chords into a list");
                                List<Rv.Data.Graphics.Types.Text.Types.Attributes.Types.CustomAttribute> customAttributes = new List<Rv.Data.Graphics.Types.Text.Types.Attributes.Types.CustomAttribute>();
                                foreach (Rv.Data.Graphics.Types.Text.Types.Attributes.Types.CustomAttribute customAttribute in slideElement.Element_.Text.Attributes.CustomAttributes)
                                {
                                    addLog("Found Custom Attribute: " + customAttribute);
                                    if (customAttribute.AttributeCase == Graphics.Types.Text.Types.Attributes.Types.CustomAttribute.AttributeOneofCase.Chord)
                                    {
                                        addLog("Adding Custom Attribute: " + customAttribute);
                                        customAttributes.Add(customAttribute);
                                    }
                                }

                                // Reverse sort list by chord position
                                addLog("Reversing list");
                                customAttributes = customAttributes.OrderByDescending(o => o.Range.Start).ToList();

                                // Insert Chords inline in reverse order (this way is easier to use original range.start to decide where to insert)
                                foreach (Rv.Data.Graphics.Types.Text.Types.Attributes.Types.CustomAttribute customChordAttribute in customAttributes)
                                {
                                    addLog("Counting text chars to find chord insertion TextPointer for: " + customChordAttribute.Chord + " at index" + customChordAttribute.Range.Start);
                                    // enumerate blocks/paragraphs/runs and count text until we find run that customChordAttribute.Range.Start would lie in...
                                    TextPointer tp = richTextBox.Document.ContentStart;
                                    int counter = 0;
                                    bool found = false;
                                    foreach (Block block in richTextBox.Document.Blocks)
                                    {
                                        if (found)
                                            break;

                                        if (block.GetType() == typeof(Paragraph))
                                        {
                                            Paragraph paragraph = (Paragraph)block;
                                            foreach (Inline inline in paragraph.Inlines)
                                            {
                                                if (found)
                                                    break;

                                                if (inline.GetType() == typeof(Run))
                                                {
                                                    Run runInline = (Run)inline;
                                                    addLog("Found a Run of text: " + runInline.Text + " (length=" + runInline.Text.Length + ")");
                                                    if (counter + runInline.Text.Length <= customChordAttribute.Range.Start)
                                                    {
                                                        counter += runInline.Text.Length;
                                                        addLog("Length Counter now: " + counter);
                                                    }
                                                    else
                                                    {
                                                        // This run contains the position of the chord...
                                                        tp = runInline.ContentStart.GetPositionAtOffset(customChordAttribute.Range.Start - counter);
                                                        addLog("Found text run for chord insertion point: Just before this text=>" + tp.GetTextInRun(LogicalDirection.Forward));
                                                        found = true;
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    if (!found)
                                        tp = richTextBox.Document.ContentEnd;

                                    // Prepare a new Run to represent a Chord with string "[*]"
                                    Run run = new Run("[" + customChordAttribute.Chord + "]");

                                    // Insert new Bolded Run with new chord
                                    Bold bold = new Bold(run, tp);
                                    TextRange tr = new TextRange(run.ContentStart, run.ContentEnd);
                                    tr.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Gray);
                                }

                                // Add RichTextBox after rtf is loaded and converted to plain text...
                                stackPanel.Children.Add(richTextBox);
                            }
                        }
                    }
                }
            }
        }

        private bool isCursorInsideChord(object sender)
        {
            RichTextBox rtb = (RichTextBox)sender;
            TextPointer tp = rtb.CaretPosition.GetInsertionPosition(LogicalDirection.Forward);
            int indexOfPreviousOpenBracket = tp.GetTextInRun(LogicalDirection.Backward).LastIndexOf("[");
            int indexOfPreviousCloseBracket = tp.GetTextInRun(LogicalDirection.Backward).LastIndexOf("]");
            int indexOfNextOpenBracket = tp.GetTextInRun(LogicalDirection.Forward).LastIndexOf("[");
            int indexOfNextClosedBracket = tp.GetTextInRun(LogicalDirection.Forward).LastIndexOf("]");
            bool firstBracketToLeftIsOpen = indexOfPreviousOpenBracket >= 0 && indexOfPreviousOpenBracket > indexOfPreviousCloseBracket;
            bool firstBracketToRightIsClosed = indexOfNextClosedBracket >= 0 && (indexOfNextClosedBracket < indexOfNextOpenBracket || indexOfNextOpenBracket == -1);
            return firstBracketToLeftIsOpen && firstBracketToRightIsClosed;
        }

        private void RichTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            TextPointer tp;
            Run run;
            Bold bold;
            TextRange tr;

            // TODO: Improve this - it's a quite rudimentry and incomplete implementation of restricting input/edits to Chords only (Easy to break/bypass)
            switch (e.Key)
            {
                case Key.A:
                case Key.B:
                case Key.C:
                case Key.D:
                case Key.E:
                case Key.F:
                case Key.G:
                    if (!isCursorInsideChord(rtb))
                    {
                        // Get current cursor position
                        tp = rtb.CaretPosition.GetInsertionPosition(LogicalDirection.Forward);
                        // Prepare a new Run to represent a Chord with string "[*]"
                        run = new Run("[" + e.Key.ToString().ToUpper() + "]");
                        // Insert new Bolded Run with new chord
                        bold = new Bold(run, tp);
                        tr = new TextRange(run.ContentStart, run.ContentEnd);
                        tr.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Gray);
                        rtb.CaretPosition = run.ContentStart.GetNextInsertionPosition(LogicalDirection.Forward).GetPositionAtOffset(1);
                        // Block any further processing of this keystroke
                        e.Handled = true;
                    }
                    break;
                case Key.OemCloseBrackets:
                case Key.OemOpenBrackets:
                    if (!isCursorInsideChord(rtb))
                    {
                        // Get current cursor position
                        tp = rtb.CaretPosition.GetInsertionPosition(LogicalDirection.Forward);
                        // Prepare a new Run to represent a Chord with string "[]"
                        run = new Run("[]");
                        // Insert new Bolded Run (Empty Chord)
                        bold = new Bold(run, tp);
                        tr = new TextRange(run.ContentStart, run.ContentEnd);
                        tr.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Gray);
                        rtb.CaretPosition = run.ContentStart.GetNextInsertionPosition(LogicalDirection.Forward);
                    }
                    // Block any further processing of this keystroke
                    e.Handled = true;
                    break;
                case Key.Left:
                case Key.Right:
                case Key.Up:
                case Key.Down:
                case Key.Home:
                case Key.End:
                    // Allow these movement keys to workinside RichTextControl
                    break;
                default:
                    // Basically block all keystrokes when cursor is outside of a pair of []
                    // Except, allowing DEL and BACKSPACE outside to remove the entire Chord/Run
                    if (!isCursorInsideChord(sender))
                    {
                        // User is typing OUTSIDE a chord []...

                        // Allow Delete if cursor is just to the left of a Chord |[*] - and remove entire chord (which is in it's own run)
                        if (e.Key == Key.Delete)
                        {
                            tp = rtb.CaretPosition.GetInsertionPosition(LogicalDirection.Forward);
                            if (tp.GetTextInRun(LogicalDirection.Forward).StartsWith("["))
                            {
                                tp.Paragraph.Inlines.Remove((Run)tp.Parent);
                            }
                        }

                        // Allow BackSpace if cursor is just to the right of a Chord [*]| - and remove entire chord (which is in it's own run)
                        if (e.Key == Key.Back)
                        {
                            tp = rtb.CaretPosition.GetInsertionPosition(LogicalDirection.Backward);
                            if (tp.GetTextInRun(LogicalDirection.Backward).EndsWith("]"))
                            {
                                tp.Paragraph.Inlines.Remove((Run)tp.Parent);
                            }
                        }
                        // Block all other keystrokes.
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void RichTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Force first char in Chord to be uppercase
            RichTextBox rtb = (RichTextBox)sender;
            TextPointer tp = rtb.CaretPosition.GetInsertionPosition(LogicalDirection.Backward);
            if (tp.GetTextInRun(LogicalDirection.Backward).EndsWith("["))
            {
                TextRange range = new TextRange(rtb.CaretPosition, rtb.CaretPosition);
                range.Text = e.TextComposition.Text.ToUpper();
                rtb.CaretPosition = range.End.GetInsertionPosition(LogicalDirection.Forward);
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String lastChordFound = "";
            String currentChordFound = "";
            Rv.Data.IntRange rangeCurrentChord;
            Rv.Data.IntRange rangeLastChord;
            List<Rv.Data.Graphics.Types.Text.Types.Attributes.Types.CustomAttribute> customChordAttributes = new List<Graphics.Types.Text.Types.Attributes.Types.CustomAttribute>();
            addLog("***SAVE CLICKED***");

            foreach (RichTextBox richTextBox in stackPanel.Children) // TODO: this is fragile and would break if I ever decide to add any non-RichTextBox children
            {
                int charIndex = 0;  // Current position (count) of characters as we enumerate through all the blocks/runs of text...(To track the position of chords that are found)
                lastChordFound = "";
                currentChordFound = "";
                rangeCurrentChord = new Rv.Data.IntRange();
                rangeLastChord = new Rv.Data.IntRange();
                customChordAttributes.Clear();
                int blockCount = 0;

                // Process block list into custom attributes
                addLog("Processing richTextBox " + stackPanel.Children.IndexOf(richTextBox));
                foreach (Block block in richTextBox.Document.Blocks)
                {
                    addLog("Processing block " + ++blockCount);
                    if (block.GetType() == typeof(Paragraph))
                    {
                        int inlineCount = 0;
                        addLog("Block " + blockCount + " is paragraph, processing inlines.");
                        Paragraph paragraph = (Paragraph)block;
                        foreach (Inline inline in paragraph.Inlines)
                        {
                            addLog("Processing inline " + ++inlineCount);
                            if (inline.GetType() == typeof(Run))
                            {
                                Run run = (Run)inline;
                                addLog("Inline " + inlineCount + " is a Run with text: " + run.Text);

                                if (run.Text.StartsWith("["))
                                {
                                    // We have a run that is a chord...

                                    // Capture any current chord into lastchord..
                                    lastChordFound = currentChordFound;
                                    rangeLastChord.Start = rangeCurrentChord.Start;

                                    // Capture current chord
                                    currentChordFound = run.Text.Substring(1, run.Text.Length - 2);
                                    rangeCurrentChord.Start = charIndex;

                                    // End last chord
                                    rangeLastChord.End = charIndex;

                                    // Here is completed chord...
                                    if (lastChordFound != "")
                                    {
                                        Graphics.Types.Text.Types.Attributes.Types.CustomAttribute customChordAttribute = new Graphics.Types.Text.Types.Attributes.Types.CustomAttribute();
                                        customChordAttribute.Range = new IntRange();
                                        customChordAttribute.Range.Start = rangeLastChord.Start;
                                        customChordAttribute.Range.End = rangeLastChord.End;
                                        customChordAttribute.Chord = lastChordFound;
                                        customChordAttributes.Add(customChordAttribute);
                                        addLog("Added chord: " + customChordAttribute);
                                    }
                                }
                                else
                                {
                                    // Increment text counter....
                                    charIndex += run.Text.Length;
                                }

                                addLog("charIndex=" + charIndex);
                                addLog("currentChordFound: " + currentChordFound + " (" + rangeCurrentChord.Start + "-" + rangeCurrentChord.End + ")");
                                addLog("lastChordFound: " + lastChordFound + " (" + rangeLastChord.Start + "-" + rangeLastChord.End + ")");
                            }
                        }
                    }
                }

                // Complete any current chord found when we reach end of text...
                if (currentChordFound != "")
                {
                    rangeCurrentChord.End = charIndex;
                    Graphics.Types.Text.Types.Attributes.Types.CustomAttribute customChordAttribute = new Graphics.Types.Text.Types.Attributes.Types.CustomAttribute();
                    customChordAttribute.Range = new IntRange();
                    customChordAttribute.Range.Start = rangeCurrentChord.Start;
                    customChordAttribute.Range.End = rangeCurrentChord.End;
                    customChordAttribute.Chord = currentChordFound;
                    customChordAttributes.Add(customChordAttribute);
                    addLog("Added chord: " + customChordAttribute);
                }

                // Get slideElement (using our crude method of linking)
                Rv.Data.Slide.Types.Element slideElement = (Rv.Data.Slide.Types.Element)richTextBox.Tag;

                // Clear all existing chord attributes (in reverse order so removal does not affect the loop!)
                addLog("Clearing existing chords");
                for (int index = slideElement.Element_.Text.Attributes.CustomAttributes.Count - 1; index >= 0; index--)
                {
                    CustomAttribute customAttribute = slideElement.Element_.Text.Attributes.CustomAttributes[index];
                    addLog("Found existing customAttribute: " + customAttribute);
                    if (customAttribute.Chord.Length > 0)
                    {
                        addLog("^^ Removed ^^");
                        slideElement.Element_.Text.Attributes.CustomAttributes.Remove(customAttribute); // TODO: HERE IS BUG!!!
                    }
                }

                foreach (var customAttribute1 in customChordAttributes)
                {
                    addLog("Adding: " + customAttribute1);
                }

                // Add our modified chord attributes
                if (customChordAttributes.Any())
                    slideElement.Element_.Text.Attributes.CustomAttributes.Add(customChordAttributes);

                addLog("About to save custom attributes:");
                foreach (var customAttribute2 in slideElement.Element_.Text.Attributes.CustomAttributes)
                {
                    addLog("Saving: " + customAttribute2);
                }
            }

            // Update Original and User MusicKeyScale (matching selected combo-box item to master list of all MUSICKEYSCALES
            if (presentation.Music == null)
            {
                Presentation.Types.Music music = new Presentation.Types.Music();
                presentation.Music = music;
            }

            try
            {
                if (cboOriginalKey.SelectedIndex >= 0)
                    presentation.Music.Original = musicKeyScales[cboOriginalKey.SelectedIndex];
                else
                    presentation.Music.Original = musicKeyScales[0];
                if (cboUserKey.SelectedIndex >= 0)
                    presentation.Music.User = musicKeyScales[cboUserKey.SelectedIndex];
                else
                    presentation.Music.User = musicKeyScales[0];
            }
            catch (Exception ex)
            {
                addLog("Excpetion: " + ex.Message);
            }

            addLog("Original Key: " + presentation.Music.Original);
            addLog("User Key: " + presentation.Music.User);

            // Save File
            addLog("About to write file: " + System.IO.Path.GetDirectoryName(selectedPro7Presentation.Path) + "\\" + presentation.Name + "-Chords.pro");
            string newFilePath = System.IO.Path.GetDirectoryName(selectedPro7Presentation.Path) + "\\" + presentation.Name + "-Chords.pro";

            if (File.Exists(newFilePath))
            {
                addLog("Removed existing: " + System.IO.Path.GetDirectoryName(selectedPro7Presentation.Path) + "\\" + presentation.Name + "-Chords.pro");
                File.Delete(newFilePath);
            }

            using (var output = File.OpenWrite(newFilePath))
            {
                addLog("Writing...");
                presentation.WriteTo(output);
                output.Close();
                addLog("Closed");
            }
            MessageBox.Show(presentation.Name + "-Chords.pro saved.");
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pro7Presentations = new List<Pro7Presentation>();
            Pro7Library selectedPro7Library = (Pro7Library)((ListView)sender).SelectedItem;
            foreach (string presentationPath in Directory.EnumerateFiles(selectedPro7Library.Path, "*.pro"))
            {
                pro7Presentations.Add(new Pro7Presentation { Name = System.IO.Path.GetFileName(presentationPath), Path = presentationPath });
            }

            listPresentations.GetBindingExpression(ListView.ItemsSourceProperty).UpdateTarget();
        }

        private void listPresentations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedPro7Presentation = (Pro7Presentation)((ListView)sender).SelectedItem;
            if (selectedPro7Presentation != null)
                loadPresentation(selectedPro7Presentation.Path);
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Warn user - don't run at same time as Pro7
            Process[] processes = Process.GetProcessesByName("ProPresenter");
            if (processes.Length > 0)
                MessageBox.Show(this, "You should not run this at same time as Pro7." + Environment.NewLine + "To avoid file corruptions, quit Pro7");

            MessageBox.Show(this, "Make sure you have a good backup of your Pro7 library documents!");
        }

        /* private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            if (tb1 != null)
            {
                tb1.Text = "";
                foreach (Inline inlineItem in ((Paragraph)rtb.Document.Blocks.FirstBlock).Inlines)
                {
                    String name = inlineItem.GetType().Name;
                    String runText = "";
                    if (name == "Run")
                    {
                        runText = ((Run)inlineItem).Text;
                    }
                    tb1.Text += name + " - " + runText + "\n";

                }
            }
        } */
    }

    public class Pro7Library
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class Pro7Presentation
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
