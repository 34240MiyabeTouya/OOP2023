<ComboBox ItemsSource="{Binding}" SelectedValue="{Binding Color}" Margin="3,30,3,3" Height="24" VerticalAlignment="Top" VerticalContentAlignment="Center" HorizontalAlignment="Left" Width="155">
	<ComboBox.ItemTemplate>
	    <DataTemplate>
	        <StackPanel Orientation="Horizontal">
	            <Border Width="20" Height="Auto" Margin="5,0" BorderThickness="1" BorderBrush="Black" Loaded="Border_Loaded"  >
	                <Border.Background>
	                    <SolidColorBrush Color="{Binding Color}"/>
	                </Border.Background>
	            </Border>
	            <TextBlock Text="{Binding Name}"></TextBlock>
	        </StackPanel>
	    </DataTemplate>
	</ComboBox.ItemTemplate>
</ComboBox>

/****************************************************************/

public partial class MainWindow : Window {
    //コンストラクタ
    public MainWindow() {
        InitializeComponent();

        DataContext = GetColorList(); //←追加

    }

    /// <summary>
    /// すべての色を取得するメソッド
    /// </summary>
    /// <returns></returns>
    private MyColor[] GetColorList() {
        return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
    }

}

/// <summary>
/// 色と色名を保持するクラス
/// </summary>
public class MyColor {
    public Color Color { get; set; }
    public string Name { get; set; }
}