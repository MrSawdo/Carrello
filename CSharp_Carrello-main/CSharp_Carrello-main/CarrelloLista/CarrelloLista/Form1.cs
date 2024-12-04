using System.Diagnostics.Eventing.Reader;

namespace CarrelloLista
{
    public partial class Form1 : Form
    {
        Carrello c;
        int conta = 0;
        Prodotto p1 = new Prodotto("0001001101", "Panigale V4R", "Ducati", 43990);
        Prodotto p2 = new Prodotto("0001001102", "Superleggera V4", "Ducati", 100000);
        Prodotto p3 = new Prodotto("0001001103", "Panigale V2", "Ducati", 20000);
        Prodotto p4 = new Prodotto("0001001104", "Multistrada V4", "Ducati", 13800);
        Prodotto p5 = new Prodotto("0001001105", "Diavel 1260 Lamborghini Limited Edition", "Ducati", 97500);

        
        public Form1()
        {
            InitializeComponent();
            c = new Carrello("c1");
            //c.aggiungiProdotto(p);
            //c.rimuoviProdotto(p);
            //c.svuotaProdotti();
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                return;

            /*if (conta == 0)
            {*/
            foreach (Prodotto n in c.Lista)
            {
                //if()
                Prodotto p = new Prodotto(comboBox1.Text, "modello", "marca", 2);
                c.aggiungiProdotto(p);

                //pictureBox1.Visible = true;
                //pictureBox2.Visible = true;

                conta++;
                //textBox1.Text = $"Hai {conta} prodotti nel carrello.";

                //MessageBox.Show("E' stato aggiunto un prodotto.");
                ListaCarrello.Items.Add(p.Id);
                textBox1.Text = "";
                Console.WriteLine("aggiungi", conta);
            }

            /*}
            else
            {
                MessageBox.Show("esiste gia un prodotto con questo seriale");
            }*/
            

        }

        private void rimuovi_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                return;

            if (conta > 0)
            {
                Prodotto p = new Prodotto(comboBox1.Text, "modello", "marca", 2);
                c.rimuoviProdotto(p);
                //pictureBox1.Visible = true;
                //pictureBox2.Visible = false;

                conta--;
                //textBox1.Text = $"Hai {conta} prodotti nel carrello.";
                if (comboBox1.Text != "")
                {
                    //MessageBox.Show("E' stato rimosso un prodotto.");
                    ListaCarrello.Items.Remove(comboBox1.Text);
                    textBox1.Text = "";
                    Console.WriteLine("rimosso", conta);
                }
                Console.WriteLine("rimosso", conta);
            }
            else
            {
                MessageBox.Show("non puoi rimuovere il prodotto! (non ce ne sono)");
                Console.WriteLine("rimosso", conta);
            }
        }

        private void svuota_Click(object sender, EventArgs e)
        {
            c.svuotaProdotti();
            //pictureBox1.Visible = true;
            //pictureBox2.Visible = false;

            conta = 0;
            //textBox1.Text = $"Hai {conta} prodotti nel carrello.";
            if (ListaCarrello.Items.Count == 0)
            {
                //MessageBox.Show("E' gia' vuota.");
                Console.WriteLine("svuota", conta);
            }
            else
            {
                Console.WriteLine("svuota", conta);
                ListaCarrello.Items.Clear();
                MessageBox.Show("E' stato svuotato il carrello.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        */
    }
}