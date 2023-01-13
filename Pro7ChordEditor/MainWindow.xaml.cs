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
            mainWindow.Title = mainWindow.Title + " (" + Assembly.GetExecutingAssembly().GetName().Version + ")";

            // Quick and rough way to build combobox list of all keys/scale without a proper data binding....
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
                    } else
                    {
                        cboOriginalKey.Items.Add(key.ToString().Replace("Flat", "b").Replace("Sharp", "#"));
                        cboUserKey.Items.Add(key.ToString().Replace("Flat", "b").Replace("Sharp", "#"));
                    }
                }
            }


            pro7Libraries = new List<Pro7Library>();
            string pro7SystemFolder;
            try
            {
                using (var sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\RenewedVision\\ProPresenter\\PathSettings.proPaths"))
                {
                    pro7SystemFolder = Regex.Match(sr.ReadToEnd().Replace(@"\\",@"\"), @"(?<=Base=).*(?=;)").Value;

                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Could not read PathSettings.proPaths");
                return;
            }

            if (Directory.Exists(pro7SystemFolder))
            {
                foreach (string libraryFolder in Directory.EnumerateDirectories(pro7SystemFolder + "Libraries"))
                {
                    pro7Libraries.Add(new Pro7Library { Name = System.IO.Path.GetFileName(libraryFolder) , Path = libraryFolder });
                }
            }

            this.DataContext = this;

        }

        private void loadPresentation(string presentationPath)
        {
            stackPanel.Children.Clear();
            using (var input = File.OpenRead(presentationPath))
            {
                presentation = Rv.Data.Presentation.Parser.ParseFrom(input);

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
                    //TODO: handle!
                }

                foreach (Rv.Data.Cue cue in presentation.Cues)
                {
                    foreach (Rv.Data.Action action in cue.Actions)
                    {
                        if (action.ActionTypeDataCase == ActionTypeDataOneofCase.Slide)
                        {
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
                                MemoryStream stream = new MemoryStream(ASCIIEncoding.Default.GetBytes(slideElement.Element_.Text.RtfData.ToStringUtf8()));
                                TextRange range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                                range.Load(stream, DataFormats.Rtf);
                                range.ClearAllProperties();
                                // Convert RTF to plain text (with no spacing between lines/paragraphs)
                                String plainText = range.Text;
                                richTextBox.Document.Blocks.Clear();
                                richTextBox.AppendText(plainText);
                                foreach (var block in richTextBox.Document.Blocks)
                                {
                                    block.Margin = new Thickness(0);
                                }

                                // I know.. this is a very crude way to make a UI element that is linked to data that is edits...but it's good for a quick demo.
                                richTextBox.Tag = slideElement;

                                // Load Chords into a list...
                                List<Rv.Data.Graphics.Types.Text.Types.Attributes.Types.CustomAttribute> customAttributes = new List<Rv.Data.Graphics.Types.Text.Types.Attributes.Types.CustomAttribute>();
                                foreach (Rv.Data.Graphics.Types.Text.Types.Attributes.Types.CustomAttribute customAttribute in slideElement.Element_.Text.Attributes.CustomAttributes)
                                {
                                    if (customAttribute.AttributeCase == Graphics.Types.Text.Types.Attributes.Types.CustomAttribute.AttributeOneofCase.Chord)
                                    {
                                        customAttributes.Add(customAttribute);
                                    }
                                }

                                // Reverse sort list by chord position
                                customAttributes = customAttributes.OrderByDescending(o=>o.Range.Start).ToList();

                                // Insert Chords inline in reverse order (this way is easier to use original range.start to decide where to insert)
                                foreach (Rv.Data.Graphics.Types.Text.Types.Attributes.Types.CustomAttribute customChordAttribute in customAttributes)
                                {
                                    System.Diagnostics.Debug.WriteLine("chord: " + customChordAttribute.Chord + " " + customChordAttribute.Range.Start);
                                    // Get insertion textpointer by 
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
                                                    System.Diagnostics.Debug.WriteLine("Run Text: " + runInline.Text + " length: " + runInline.Text.Length);
                                                    if (counter + runInline.Text.Length <= customChordAttribute.Range.Start)
                                                    {
                                                        counter += runInline.Text.Length;
                                                        System.Diagnostics.Debug.WriteLine("Incrementing Counter: " + counter);
                                                    } 
                                                    else
                                                    {
                                                        // This run contains the position of the chord...
                                                        tp = runInline.ContentStart.GetPositionAtOffset(customChordAttribute.Range.Start - counter);
                                                        System.Diagnostics.Debug.WriteLine("Text after chord position:" + tp.GetTextInRun(LogicalDirection.Forward));
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


            foreach (RichTextBox richTextBox in stackPanel.Children) // TODO: this is fragile and would break if I ever decide to add any non-RichTextBox children
            {
                int charIndex = 0;  // Current position (count) of characters as we enumerate through all the blocks/runs of text...(To track the position of chords that are found)
                lastChordFound = "";
                currentChordFound = "";
                rangeCurrentChord = new Rv.Data.IntRange();
                rangeLastChord = new Rv.Data.IntRange();
                customChordAttributes.Clear();

                // Process block list into custom attributes
                foreach (Block block in richTextBox.Document.Blocks)
                {
                    if (block.GetType() == typeof(Paragraph))
                    {
                        Paragraph paragraph = (Paragraph)block;
                        foreach (Inline inline in paragraph.Inlines)
                        {
                            if (inline.GetType() == typeof(Run))
                            {
                                Run run = (Run)inline;

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
                                        System.Diagnostics.Debug.WriteLine(lastChordFound + " " + rangeLastChord.Start + "-" + rangeLastChord.End);
                                    }

                                }
                                else
                                {
                                    // we have a run of lyric text
                                    System.Diagnostics.Debug.WriteLine(run.Text);

                                    // Increment text counter....
                                    charIndex += run.Text.Length;
                                }



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
                    System.Diagnostics.Debug.WriteLine(currentChordFound + " " + rangeCurrentChord.Start + "-" + rangeCurrentChord.End);
                }


                // Get slideElement (using our crude method of linking)
                Rv.Data.Slide.Types.Element slideElement = (Rv.Data.Slide.Types.Element)richTextBox.Tag;

                // Clear all existing chord attributes
                foreach (var customAttribute in slideElement.Element_.Text.Attributes.CustomAttributes)
                {
                    if (customAttribute.AttributeCase == Graphics.Types.Text.Types.Attributes.Types.CustomAttribute.AttributeOneofCase.Chord)
                    {
                        slideElement.Element_.Text.Attributes.CustomAttributes.Remove(customAttribute);
                        customAttribute.ClearAttribute();
                    }
                }

                // Add our modified chord attributes
                if (customChordAttributes.Any())
                    slideElement.Element_.Text.Attributes.CustomAttributes.Add(customChordAttributes);


                // Process ChordPro text into customattributes
                //TextRange range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                //String plainText = range.Text;

            }

            // Update Original and User MusicKeyScale (matching selected combo-box item to master list of all MUSICKEYSCALES
            if (presentation.Music == null)
            {
                Presentation.Types.Music music = new Presentation.Types.Music();
                presentation.Music = music;
            }

            presentation.Music.Original = musicKeyScales[cboOriginalKey.SelectedIndex];
            presentation.Music.User = musicKeyScales[cboUserKey.SelectedIndex];

            // Save File
            string newFilePath = System.IO.Path.GetDirectoryName(selectedPro7Presentation.Path) + "\\" + presentation.Name + "-Chords.pro";
            
            if (File.Exists(newFilePath))
                File.Delete(newFilePath);

            using (var output = File.OpenWrite(newFilePath))
            {
                presentation.WriteTo(output);
                output.Close();
            }

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pro7Presentations = new List<Pro7Presentation>();
            Pro7Library selectedPro7Library = (Pro7Library)((ListView)sender).SelectedItem;
            foreach (string presentationPath in Directory.EnumerateFiles(selectedPro7Library.Path,"*.pro"))
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

        /*private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
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

