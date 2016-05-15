using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace DTAAuftragsdateiAnalysator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                OpenFile.Text = openFileDialog.FileName;
                using (var fstream = File.Open(openFileDialog.FileName, FileMode.Open))
                {
                    long fileLength = fstream.Length;
                    //StructType extracted = this.ByteToType(fstream);
                    this.Data.Clear();
                    var extracted = this.ByteToTypeExplicit(fstream);

                    long auftragLength = long.Parse(extracted.LÄNGE_AUFTRAG);
                    if (auftragLength != fileLength)
                    {
                        this.Valid = Brushes.Red;
                    }
                    else
                    {
                        this.Valid = Brushes.White;
                    }
                }
            }
        }

        public Auftragsdatei ByteToTypeExplicit(FileStream fstream)
        {
            var extracted = new Auftragsdatei();
            using (var breader = new BinaryReader(fstream))
            {
                foreach (var field in typeof(Auftragsdatei).GetFields())
                {
                    View view = (AuftragAttribute)field.GetCustomAttributes(typeof(AuftragAttribute), false).FirstOrDefault();
                    view.Name = field.Name;
                    //field.GetValue(extracted).ToString();

                    fstream.Position = view.Stelle - 1;
                    var bytes = breader.ReadBytes(view.Länge);
                    string result = ASCIIEncoding.ASCII.GetString(bytes);
                    field.SetValue(extracted, result);

                    view.Value = result;
                    this.Data.Add(view);
                }
            }
            return extracted;
        }
        //bug mit Strings
        public Auftragsdatei ByteToType(FileStream fstream)
        {
            using (var stream = new BinaryReader(fstream))
            {
                byte[] bytes = stream.ReadBytes(Marshal.SizeOf(typeof(Auftragsdatei)));
                GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                Auftragsdatei theStructure = (Auftragsdatei)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(Auftragsdatei));
                handle.Free();

                return theStructure;
            }
        }

        public SolidColorBrush Valid { get; set; } = Brushes.White;

        public ObservableCollection<View> Data { get; set; } = new ObservableCollection<View>();
    }
}