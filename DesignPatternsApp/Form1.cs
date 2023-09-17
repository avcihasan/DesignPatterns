using DesignPatternsApp.Adapter;
using DesignPatternsApp.Observer;
using DesignPatternsApp.Singleton;
using DesignPatternsApp.Strategy;

namespace DesignPatternsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectDesignPattern_Click(object sender, EventArgs e)
        {
            RadioButton radioBtn = this.Controls.OfType<RadioButton>()
                                       .Where(x => x.Checked).FirstOrDefault()!;
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "singletonPattern":
                        SingletonForm singletonForm = new();
                        singletonForm.Show();
                        break;
                    case "observerPattern":
                        ObserverForm observerPattern = new();
                        observerPattern.Show();
                        break;
                    case "adapterPattern":
                        AdapterForm adapterPattern = new();
                        adapterPattern.Show();
                        break;
                    case "strategyPattern":
                        StrategyForm strategyPattern = new();
                        strategyPattern.Show();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}