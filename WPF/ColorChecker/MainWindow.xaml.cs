using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        MyColor originalColor;
        public MainWindow() {
            InitializeComponent();

            DataContext = GetColorList();

        }
        double r = 0;
        double g = 0;
        double b = 0;
        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            originalColor = new MyColor {
                Color = Color.FromRgb(byte.Parse(rValue.Text), byte.Parse(gValue.Text), byte.Parse(bValue.Text)),
                Name = "",
            };
            colorArea.Background = new SolidColorBrush(Color.FromRgb(originalColor.Color.R, originalColor.Color.G, originalColor.Color.B));
            setColor();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            setColor(); //起動時に初期状態の設定値（R:0 G:0 B:0）から色を設定
        }

        //テキストボックスの値を元に色を設定
        private void setColor() {
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            colorArea.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            originalColor = (MyColor)((ComboBox)sender).SelectedItem;
            this.r = originalColor.Color.R;
            this.g = originalColor.Color.G;
            this.b = originalColor.Color.B;
            rSlider.Value = r;
            gSlider.Value = g;
            bSlider.Value = b;
            setColor();
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            this.r = originalColor.Color.R;
            this.g = originalColor.Color.G;

            var name = GetColorList().Where(c => c.Color.R == this.r
                                    && c.Color.G == this.g
                                    && c.Color.B == this.b)
                          .FirstOrDefault()?.Name;
            stockList.Items.Insert(0, name == "" || name == null ? originalColor.ToString() : name);
        }

        private void stockList_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            object[] vs = new object[3];
            int i = 0;
            //ストックしてある色をダブルクリックして取得
            var data = stockList.Items[stockList.SelectedIndex];
            var matches = Regex.Matches((string)data, @"\d+");
            if (matches != null) {
                foreach (object match in matches) {
                    vs[i] = match;
                    i++;
                }
            } else {
                var color = GetColorList().Where(c => c.Name.Equals(data)).FirstOrDefault();
                //var matche = Regex.Matches((string)color, @"\d+");
                //foreach (object match in matche) {
                //    vs[i] = match;
                //    i++;
                //}

                rValue.Text = vs[0].ToString();
                gValue.Text = vs[1].ToString();
                bValue.Text = vs[2].ToString();
            }
        }

        /// <summary>
        /// 色と色名を保持するクラス
        /// </summary>
        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
            public override string ToString() {
                return "R : " + Color.R + "   G : " + Color.G + "   B : " + Color.B;
            }
        }
    }
}
