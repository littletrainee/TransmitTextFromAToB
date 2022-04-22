using System.Windows;
using System.Windows.Controls;

namespace WpfApp1;
/// <summary>
/// Set Text to InfoB
/// </summary>
public partial class UserControlB : UserControl {
  public static string? InfoB { get; set; }
  public UserControlB() =>
    InitializeComponent();
  private void TransmitTextButton_Click(object sender, RoutedEventArgs e) =>
    InfoB = UBTxt.Text.ToString();
}
