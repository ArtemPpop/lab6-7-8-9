using System.Collections.Generic;
using System.Linq;
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

        private void InsertNegativeBeforeTwenty()
        {
            // Поиск первого отрицательного элемента
            double? firstNegative = listLab3.FirstOrDefault(item => item < 0);

            // Если отрицательный элемент существует
            if (firstNegative.HasValue)
            {
                // Создаем временный список для хранения результатов
                var tempList = new LinkedList<double>();
                foreach (var item in listLab3)
                {
                    // Если текущий элемент равен 20, вставляем перед ним первый отрицательный элемент
                    if (item == 20)
                    {
                        tempList.Add(firstNegative.Value);
                    }
                    tempList.Add(item);
                }

                // Очищаем основной список и копируем в него элементы из временного списка
                listLab3.Clear();
                foreach (var item in tempList)
                {
                    listLab3.Add(item);
                }
            }
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
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            InsertNegativeBeforeTwenty();
            lbList3.Items.Clear();
            foreach (double item in listLab3)
            {
                lbList3.Items.Add(item);
            }
        }





        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            listLab3.Clear();
            lbList3.Items.Clear();
        }

        
    }

        
}