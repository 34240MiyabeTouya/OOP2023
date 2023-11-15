using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel {
        private double metricValue, imperialValue, gramsValue, poundValue;


        public double MetricValue {
            get { return this.metricValue; }
            set {
                this.metricValue = value;
                this.OnPropertyChanged();
            }
        }

        public double ImperialValue {
            get { return this.imperialValue; }
            set {
                this.imperialValue = value;
                this.OnPropertyChanged();
            }
        }

        public double GramsValue {
            get { return this.gramsValue; }
            set {
                this.gramsValue = value;
                this.OnPropertyChanged();
            }
        }

        public double PoundValue {
            get { return this.poundValue; }
            set {
                this.poundValue = value;
                this.OnPropertyChanged();
            }
        }

        //上のComboBoxで選択されている値（単位）
        public MetricUnit CurrentMetricUnit { get; set; }//メートル
        public GramsUnit CurrentGramsUnit { get; set; }//グラム
        //下のComboBoxで選択されている値（単位）
        public ImperialUnit CurrentImperialUnit { get; set; }//ヤード
        public PoundUnit CurrentPoundUnit { get; set; }//ポンド
        //▲ボタンで呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }
        public ICommand PoundUnitToGrams { get; set; }
        //▼ボタンで呼ばれるコマンド
        public ICommand MetricToImperialUnit { get; private set; }
        public ICommand GramsUnitToPound { get; set; }

        //コンストラクタ
        public MainWindowViewModel() {
            this.CurrentGramsUnit = GramsUnit.Units.First();
            this.CurrentPoundUnit = PoundUnit.Units.First();

            this.GramsUnitToPound = new DelegateCommand(
                () => this.PoundValue = this.CurrentPoundUnit.FromGramsUnit(
                    this.CurrentGramsUnit, this.GramsValue));

            this.PoundUnitToGrams = new DelegateCommand(
                () => this.GramsValue = this.CurrentGramsUnit.FromPoundUnit(
                    this.CurrentPoundUnit, this.PoundValue));
        }
    }
}
