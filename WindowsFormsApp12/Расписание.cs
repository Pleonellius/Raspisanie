using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Расписание : MetroFramework.Forms.MetroForm
    {
        string connStr = "server=chuc.caseum.ru;port=33333;user=st_2_19_1;database=is_2_19_st1_KURS;password=58458103;";
        public Расписание()
        {
            InitializeComponent();
        }
        //Переменная соединения
        MySqlConnection conn;
        //DataAdapter представляет собой объект Command , получающий данные из источника данных.
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        //Объявление BindingSource, основная его задача, это обеспечить унифицированный доступ к источнику данных.
        private BindingSource bSource = new BindingSource();
        //DataSet - расположенное в оперативной памяти представление данных, обеспечивающее согласованную реляционную программную 
        //модель независимо от источника данных.DataSet представляет полный набор данных, включая таблицы, содержащие, упорядочивающие 
        //и ограничивающие данные, а также связи между таблицами.
        private DataSet ds = new DataSet();
        //Представляет одну таблицу данных в памяти.
        private DataTable table = new DataTable();
        public void GetListUsers()
        {
            //Запрос для вывода строк в БД
            string commandStr = "SELECT IMAVraha AS 'Ф.И.О Врача', Special AS 'Специальность', phone AS 'Телефон', obrazovanie AS 'Образование', kabinet AS 'Кабинет',vrema AS 'Время' FROM Vrahi";
            //Открываем соединение
            conn.Open();
            //Объявляем команду, которая выполнить запрос в соединении conn
            MyDA.SelectCommand = new MySqlCommand(commandStr, conn);
            //Заполняем таблицу записями из БД
            MyDA.Fill(table);
            //Указываем, что источником данных в bindingsource является заполненная выше таблица
            bSource.DataSource = table;
            //Указываем, что источником данных ДатаГрида является bindingsource 
            dataGridView1.DataSource = bSource;
            //Закрываем соединение
            conn.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            string connStr = "server=10.90.12.110;port=33333;user=st_2_19_1;database=is_2_19_st1_KURS;password=58458103;";
            // создаём объект для подключения к БД
            conn = new MySqlConnection(connStr);
        }

        private void metroToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form5 = new Form2();
            form5.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form5 = new Form2();
            form5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form5 = new Form4();
            form5.ShowDialog();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedIndex)
            {

                case 0:
                    bSource.Filter = "";
                    break;
                case 1:
                    bSource.Filter = $"[Специальность] LIKE'" + "Хирург" + "%'";
                    break;
                case 2:
                    bSource.Filter = $"[Специальность] LIKE'" + "Дерматолог" + "%'";
                    break;
                case 3:
                    bSource.Filter = $"[Специальность] LIKE'" + "Окулист" + "%'";
                    break;
                case 4:
                    bSource.Filter = $"[Специальность] LIKE'" + "Терапевт" + "%'";
                    break;
            }
        }
        //удаление записи из БД
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ControlData.DeleteUser(id_selected_rows);
        }

        //Отчислить студента
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ControlData.ChangeStateStudent("1", id_selected_rows);
            //Метод обновления dataGridView, так как он полностью обновляется, покраски строк не будет. 
            reload_list();
            //Красим опять грид
            ChangeColorDGV();
        }

        //Зачислить студента 
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ControlData.ChangeStateStudent("2", id_selected_rows);
            //Метод обновления dataGridView, так как он полностью обновляется, покраски строк не будет. 
            reload_list();
            //Красим опять грид
            ChangeColorDGV();
        }
        //Метод изменения цвета строк, в зависимости от значения поля записи в таблице
        private void ChangeColorDGV()
        {
            //Отражаем количество записей в ДатаГриде
            int count_rows = dataGridView1.RowCount - 1;
            toolStripLabel2.Text = (count_rows).ToString();
            //Проходимся по ДатаГриду и красим строки в нужные нам цвета, в зависимости от статуса студента
            for (int i = 0; i < count_rows; i++)
            {

                //статус конкретного студента в Базе данных, на основании индекса строки
                int id_selected_status = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                //Логический блок для определения цветности
                if (id_selected_status == 1)
                {
                    //Красим в красный
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if (id_selected_status == 2)
                {
                    //Красим в зелёный
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }
    }
}
