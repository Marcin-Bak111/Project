using Przelicznik.Database.Context.Entities;
using Przelicznik.Database.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przelicznik
{
    public partial class MainWindow : Form
    {
        private ConverterDbRepository converterDbRepository;
        

        public MainWindow()
        {
            InitializeComponent();
            converterDbRepository = new ConverterDbRepository();

            List<UnitType> ListOfUnitType = converterDbRepository.ReadAllUnitType();
            ComboBoxType.SelectedIndexChanged -= ComboBoxType_SelectedIndexChanged;
            ComboBoxType.DataSource = ListOfUnitType;
            ComboBoxType.DisplayMember = "Name";
            ComboBoxType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;
            
            
            //foreach (UnitType element in ListOfUnitType)
                //ComboBoxType.Items.Add(element.Name);
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitType selectedUnitType = ComboBoxType.SelectedItem as UnitType;
            List<Unit> listofSourceUnits = converterDbRepository.ReadChosenUnit(selectedUnitType.Id);
            List<Unit> listofTargetUnits = converterDbRepository.ReadChosenUnit(selectedUnitType.Id);

            ComboBoxStartUnit.DataSource = listofSourceUnits;
            ComboBoxStartUnit.DisplayMember = "Name";

            ComboBoxTargetUnit.DataSource = listofTargetUnits;
            ComboBoxTargetUnit.DisplayMember = "Name";

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Unit sourceUnit = ComboBoxStartUnit.SelectedItem as Unit;
            Unit targetUnit = ComboBoxTargetUnit.SelectedItem as Unit;

            UnitConverter unitConverter = converterDbRepository.ReadUnitConverter(sourceUnit.Id, targetUnit.Id);

            decimal targetValue = NumericUpDownResult.Value * (decimal)unitConverter.ConvertValue;

            labelResult.Text = NumericUpDownResult.Value
                + sourceUnit.Symbol
                + " = "
                + targetValue = targetUnit.Symbol; 

            
        }
    }
}
