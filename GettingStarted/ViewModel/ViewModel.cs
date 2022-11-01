using Syncfusion.UI.Xaml.Barcode;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace GettingStarted
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private BarcodeBase symbologyItem = new CodabarBarcode();

        private Model selectedItem = new Model();

        private double moduleValue = 2;

        public ViewModel()
        {
            Symbology = new ObservableCollection<Model>();
            Symbology.Add(new Model() { SymobologyItem = "CodaBar" });
            Symbology.Add(new Model() { SymobologyItem = "Code11" });
            Symbology.Add(new Model() { SymobologyItem = "Code32" });
            Symbology.Add(new Model() { SymobologyItem = "Code39" });
            Symbology.Add(new Model() { SymobologyItem = "Code39Extended" });
            Symbology.Add(new Model() { SymobologyItem = "Code93" });
            Symbology.Add(new Model() { SymobologyItem = "Code93Extended" });
            Symbology.Add(new Model() { SymobologyItem = "Code128A" });
            Symbology.Add(new Model() { SymobologyItem = "Code128B" });
            Symbology.Add(new Model() { SymobologyItem = "Code128C" });
            Symbology.Add(new Model() { SymobologyItem = "UpcBarcode" });
            Symbology.Add(new Model() { SymobologyItem = "DataMatrix" });
            Symbology.Add(new Model() { SymobologyItem = "QRBarcode" });
        }

        public ObservableCollection<Model> Symbology { get; }

        public double ModuleValue
        {
            get
            {
                return moduleValue;
            }
            set
            {
                moduleValue = value;
                OnPropertyChanged("ModuleValue");
            }
        }

        public BarcodeBase SymbologyItem
        {
            get
            {
                return symbologyItem;
            }
            set
            {
                symbologyItem = value;
                OnPropertyChanged("SymbologyItem");
            }
        }

        public Model SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                UpdateSymbology(selectedItem);
                OnPropertyChanged("SelectedItem");
            }
        }

        private void UpdateSymbology(Model barcodeModel)
        {
            switch (barcodeModel.SymobologyItem)
            {
                case "CodaBar":
                    CodabarBarcode codabarBarcode = new CodabarBarcode();
                    SymbologyItem = codabarBarcode;
                    ModuleValue = 2;
                    break;
                case "Code11":
                    Code11Barcode code11Barcode = new Code11Barcode();
                    SymbologyItem = code11Barcode;
                    ModuleValue = 2;
                    break;
                case "Code32":
                    Code32Barcode code32Barcode = new Code32Barcode();
                    SymbologyItem = code32Barcode;
                    ModuleValue = 2;
                    break;
                case "Code39":
                    Code39Barcode code39Barcode = new Code39Barcode();
                    SymbologyItem = code39Barcode;
                    ModuleValue = 2;
                    break;
                case "Code39Extended":
                    Code39ExtendedBarcode code39ExtendedBarcode = new Code39ExtendedBarcode();
                    SymbologyItem = code39ExtendedBarcode;
                    ModuleValue = 2;
                    break;
                case "Code93":
                    Code93Barcode code93Barcode = new Code93Barcode();
                    SymbologyItem = code93Barcode;
                    ModuleValue = 2;
                    break;
                case "Code93Extended":
                    Code93ExtendedBarcode code93ExtendedBarcode = new Code93ExtendedBarcode();
                    SymbologyItem = code93ExtendedBarcode;
                    ModuleValue = 2;
                    break;
                case "Code128A":
                    Code128ABarcode code128Barcode = new Code128ABarcode();
                    SymbologyItem = code128Barcode;
                    ModuleValue = 2;
                    break;
                case "Code128B":
                    Code128BBarcode code128BBarcode = new Code128BBarcode();
                    SymbologyItem = code128BBarcode;
                    ModuleValue = 2;
                    break;
                case "Code128C":
                    Code128CBarcode code128CBarcode = new Code128CBarcode();
                    SymbologyItem = code128CBarcode;
                    ModuleValue = 2;
                    break;
                case "UpcBarcode":
                    UpcBarcode upcBarcode = new UpcBarcode();
                    SymbologyItem = upcBarcode;
                    ModuleValue = 2;
                    break;
                case "DataMatrix":
                    DataMatrixBarcode dataMatrixBarcode = new DataMatrixBarcode();
                    SymbologyItem = dataMatrixBarcode;
                    ModuleValue = 6;
                    break;
                case "QRBarcode":
                    QRBarcode qRBarcode = new QRBarcode();
                    SymbologyItem = qRBarcode;
                    ModuleValue = 4;
                    break;
            }
        }

        private void OnPropertyChanged(string Parameter)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(Parameter));
        }
    }
}
