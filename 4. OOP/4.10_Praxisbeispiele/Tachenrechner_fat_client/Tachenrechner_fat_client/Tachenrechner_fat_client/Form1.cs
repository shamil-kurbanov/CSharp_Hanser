namespace Tachenrechner_fat_client
{
    public partial class Form1 : Form
    {
        private string op; // aktueller Operator (+, -, *, /)
        private string reg1 = string.Empty; //Erstes Register (Operand)
        private string reg2 = string.Empty; //Zweites Register (Operand)

        //Wir wollen zur Steuerung des Programmablaufs eine spezielle Variable "state" verwenden
        //die den aktuellen Zustand speichert:

        private int state = 1; //aktuelles Register (1 oder 2)



        public Form1()
        {
            InitializeComponent();

            /*
             * Die Erste Gruppe von Eventhandlern bezieht sich auf den Ziffernblock und verweist auf die gemeinsam genutzte 
             * Methode ButtonZ_Click
             */

            bt_1.Click += new EventHandler(ButtonZ_Click);   //1
            bt_2.Click += new EventHandler(ButtonZ_Click);   //2
            bt_3.Click += new EventHandler(ButtonZ_Click);   //3
            bt_4.Click += new EventHandler(ButtonZ_Click);   //4
            bt_5.Click += new EventHandler(ButtonZ_Click);   //5
            bt_6.Click += new EventHandler(ButtonZ_Click);   //6
            bt_7.Click += new EventHandler(ButtonZ_Click);   //7
            bt_8.Click += new EventHandler(ButtonZ_Click);   //8
            bt_9.Click += new EventHandler(ButtonZ_Click);   //9
            bt_0.Click += new EventHandler(ButtonZ_Click);   //0
            bt_dot.Click += new EventHandler(ButtonZ_Click); //,

            /*
             * Die Zweite Gruppe von Eventhandlern bezieht sich auf die vier Operationstasten, die auf die gemeinsam genutzte 
             * Methode ButtonZ_Click verweisen
             */

            this.bt_plus.Click += new EventHandler(ButtonOp_Click);             // +
            this.bt_minus.Click += new EventHandler(ButtonOp_Click);            // -
            this.bt_multiplication.Click += new EventHandler(ButtonOp_Click);   // *
            this.bt_division.Click += new EventHandler(ButtonOp_Click);         // "/"

        }

        /*
         * Die durchgefürten Aktionen in der Methoden ButtonZ_Click und ButtonOp_Click sind von Wert der Zustandvariablen "state"
         * abhängig, die somit die Rolle einer "Programmweiche (Program switch) übernimmt 
         */

        private void ButtonZ_Click(object? sender, EventArgs e)
        {
            Button? cmd = (Button?)sender;

            //In Abhängigkeit von "state" wird die Eingabe zum ersten oder zum zweiten Register hinzugefügt. Der Wert der einzugebenden Ziffer
            //wird dabei der Text-Eigenschaft des Buttons entnommen

            switch (state)
            {
                case 1: //zum ersten Operanden hinzufügen
                    reg1 += cmd.Text[0];
                    lb_result.Text = reg1;
                    break;
                case 2: //zum zweiten Operanden hinzufügen
                    reg2 += cmd.Text[0];
                    lb_result.Text = reg1 + " " + op + " " + reg2;
                    break;
            }
        }

        //Bei der Eingabe des Operators (+, -, *, /) wird ähnlich verfahren
        private void ButtonOp_Click(object? sender, EventArgs e)
        {
            Button? cmd = (Button?)sender;
            switch (state)
            {
                case 1: //neuer Operand
                    op = cmd.Text;
                    state = 2;
                    break;
                case 2:
                    Ergebnis(); //Zwischenergebnis mit altem Operand ermitteln
                    op = cmd.Text; // ... dann neuer Operand
                    break;
            }
            lb_result.Text = reg1.ToString() + " " + op;
            reg2 = string.Empty; //Register2 löschen
        }

        //Die folgende Hilfsprozedur führt die Rechenoperation aus und speichert deren Ergebnis im Register1
        private void Ergebnis()
        {
            double r1 = Convert.ToDouble(reg1);
            double r2 = Convert.ToDouble(reg2);

            switch (op)
            {
                case "+":
                    reg1 = (r1 + r2).ToString();
                    break;
                case "-":
                    reg1 = (r1 - r2).ToString();
                    break;
                case "*":
                    reg1 = (r1 * r2).ToString();
                    break;
                case "/":
                    reg1 = (r1 / r2).ToString();
                    break;
            }
            reg2 = string.Empty; //löscht Register2
        }

        //-------- Die Ergebnistaste (=) --------
        private void bt_result_Click(object sender, EventArgs e)
        {
            if (state == 2)
            {
                Ergebnis();
                lb_result.Text += " " + reg1;
                state = 1;
            }
            else
            {
                lb_result.Text = reg1;
                reg2 = string.Empty; //löscht Register2
            }
        }

        //Letztes eingegebenes Zeichen löschen (CE)
        private void bt_ce_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 1:
                    if (!string.IsNullOrEmpty(reg1))
                    {
                        reg1 = reg1.Remove(reg1.Length - 1, 1);
                        lb_result.Text = reg1;
                    };
                    break;
                case 2:
                    if (!string.IsNullOrEmpty(reg2))
                    {
                        reg2 = reg2.Remove(reg2.Length - 1, 1);
                        lb_result.Text = reg2;
                    };
                    break;
            }
        }

        //Alle Register sowie Anzeige löschen und Anfangszustand herstellen (CLR)
        private void bt_clr_Click(object sender, EventArgs e)
        {
            reg1 = string.Empty;
            reg2 = string.Empty;
            lb_result.Text = string.Empty;
            state = 1;
        }

        //Schließlich noch der Vorzeichenwechsel (+/-)
        private void bt_plus_minus_Click(object sender, EventArgs e)
        {
            double r;
            switch (state)
            {
                case 1:
                    r = -Convert.ToDouble(reg1);
                    reg1 = r.ToString();
                    lb_result.Text = reg1;
                    break;
                case 2:
                    r = -Convert.ToDouble(reg2);
                    reg2 = r.ToString();
                    lb_result.Text = reg1 + " " + op + " " + reg2;
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}