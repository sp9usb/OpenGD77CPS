using System;
using System.Windows.Forms;

namespace Extras.FirmwareLoader
{
    internal partial class InformationAboutSetRadioToLoadingFirmwareUI : Form
    {
        private readonly DMR.FirmwareLoader.OutputType _specificRadio;
        
        public InformationAboutSetRadioToLoadingFirmwareUI(DMR.FirmwareLoader.OutputType specificRadio)
        {
            _specificRadio = specificRadio;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            bool showInformation = true;
            informationalLabel.Text = "Before starting upload firmware, click the buttons and turn on the radio.";
            switch (_specificRadio)
            {
                case DMR.FirmwareLoader.OutputType.OutputType_GD77:
                case DMR.FirmwareLoader.OutputType.OutputType_GD77S:
                    settingRadioImage.Image = Properties.Resources.gd_77_key;
                    break;
                default:
                    showInformation = false;
                    break;
            }
            if (!showInformation)
            {
                Close();
            }
            else
            {
                base.OnShown(e);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
