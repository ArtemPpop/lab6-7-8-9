using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab6_7_8_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<double> listLab1;
        private Queue<string> queue;
        private LinkedList<double> listLab3;
        public MainWindow()
        {
            InitializeComponent();
            listLab1 = new List<double>();
            queue = new Queue<string>();
            listLab3 = new LinkedList<double>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listLab1.Add(int.Parse(tbElement.Text));
            lbList.ItemsSource = null;
            lbList.ItemsSource = listLab1;
            tbElement.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int index = lbList.SelectedIndex;
            listLab1.RemoveAt(index);
            lbList.ItemsSource = null;
            lbList.ItemsSource = listLab1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int count = 0;
            foreach (int l in listLab1)
            {
                if (listLab1[l] % 2 != 0)
                    count++;
            }
            Result.Text = "количество нечётных:" + count.ToString();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            queue.Enqueue(tbElementQueue.Text);
            lbQueue.ItemsSource = null;
            lbQueue.ItemsSource = queue.Cast<object>();
            tbElementQueue.Text = "";
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string inputString = tbCount.Text;
            char[] chars = inputString.ToCharArray();

            foreach (char c in chars)
            {
                queue.Enqueue(c.ToString());
            }

            lbQueue.ItemsSource = null;
            lbQueue.ItemsSource = queue.Cast<object>();

            string result = string.Join(" ", queue);
            tbResultQueue.Text = result;
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double elementToAdd = double.Parse(tbElementAdd.Text);
            listLab3.Add(elementToAdd);
            lbList3.Items.Clear();
            foreach (double item in listLab3)
            {
                lbList3.Items.Add(item);
            }
            tbElementAdd.Text = "";
        }
        public static void InsertBefore20(List<double> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 20 && i > 0)
                {
                    double negativeNum = list[i - 1];
                    list.Insert(i, negativeNum);
                    i++;
                }
            }
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            InsertBefore20(listLab3);
            lbList3.Items.Clear();
            foreach (double item in listLab3)
            {
                lbList3.Items.Add(item);
            }
        }

        private void InsertBefore20(LinkedList<double> listLab3)
        {
             static void InsertBefore20(List<double> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == 20 && i > 0)
                    {
                        double negativeNum = list[i - 1];
                        list.Insert(i, negativeNum);
                        i++;
                    }
                }
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            listLab3.Clear();
            lbList3.Items.Clear();
        }

        
    }

        
}