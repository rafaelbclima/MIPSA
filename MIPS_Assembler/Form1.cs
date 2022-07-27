using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIPS_Assembler
{
    public partial class Form1 : Form
    {
        public string Status
        {
            set
            {
                textBox_Status.Text = value;
            }
        }
        bool flag_error = false;
        string sep = "";
        string mif_name = "RomInstMem_init";
        //string[] mif_cabecalho = { "WIDTH = 32;", "DEPTH=256;", "ADDRESS_RADIX=UNS;","DATA_RADIX=BIN;", "CONTENT BEGIN"}; Environment.NewLine
        string mif_cabecalho = "--Arquivo gerado para o LASD - UFCG - Prof. Rafael Lima" + Environment.NewLine
            + "WIDTH = 32;" + Environment.NewLine 
            + "DEPTH=256;" + Environment.NewLine 
            + "ADDRESS_RADIX=UNS;" + Environment.NewLine 
            + "DATA_RADIX=BIN;" + Environment.NewLine 
            + "CONTENT BEGIN" + Environment.NewLine;
        public Form1()
        {
            InitializeComponent();
        }

        private void converterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox_cod_maq.Text = tipo_r("ADD $2, $0, $1");
            //richTextBox_cod_maq.Text = tipo_j(richTextBox_MIPS.Lines[0]);
            try
            {
                flag_error = false;
                //Converter para o richtextbox
                richTextBox_cod_maq.Text = "";
                foreach (string element in richTextBox_MIPS.Lines)
                {
                    richTextBox_cod_maq.Text += assembler_mips(element, sep) + "\n";
                }
                //Escrever no arquivo

                string mif_instructions = "";
                mif_instructions = String.Copy(mif_cabecalho);
                for (int i = 0; i < richTextBox_MIPS.Lines.Length; i++)
                {
                    mif_instructions += i.ToString() + "\t:\t" + assembler_mips(richTextBox_MIPS.Lines[i], "") + ";" + Environment.NewLine;
                }
                mif_instructions += "[" + richTextBox_MIPS.Lines.Length.ToString() + "..255]  :   00000000000000000000000000000000;" + Environment.NewLine;
                mif_instructions += "END;";
                mif_instructions += Environment.NewLine + Environment.NewLine + "#Assembly MIPS#" + Environment.NewLine + richTextBox_MIPS.Text + Environment.NewLine;
                mif_instructions += "#Comentarios#" + Environment.NewLine + richTextBox_comentarios.Text + Environment.NewLine;

                if (flag_error == false)
                {
                    System.IO.File.WriteAllText(mif_name + ".mif", mif_instructions);
                }
                else
                {
                    Status = "Instrução não suportada ou formato inválido";
                    MessageBox.Show("Instrução não suportada ou formato inválido!\nVerifique se ficou algum espaço ou linha em branco.");
                }
            }
            catch
            {
                Status = "Instrução não suportada ou formato inválido";
            }
        }

        private string assembler_mips(string instrucao, string sep)
        {
            string[] campos = instrucao.ToLower().Split(' ');
            string Inst = campos[0];

            switch (Inst)
            {
                case "add":
                    return tipo_r(instrucao, sep);
                    break;
                case "sub":
                    return tipo_r(instrucao, sep);
                    break;
                case "and":
                    return tipo_r(instrucao, sep);
                    break;
                case "or":
                    return tipo_r(instrucao, sep);
                    break;
                case "slt":
                    return tipo_r(instrucao, sep);
                    break;
                case "addi":
                    return tipo_i(instrucao, sep);
                    break;
                case "beq":
                    return tipo_i(instrucao, sep);
                    break;
                case "lw":
                    return tipo_mem(instrucao, sep);
                    break;
                case "sw":
                    return tipo_mem(instrucao, sep);
                    break;
                case "j":
                    return tipo_j(instrucao, sep);
                    break;
                default:
                    Status = "Instrução não suportada ou formato inválido";
                    flag_error = true;
                    return "@@@@@@_@@@@@_@@@@@_@@@@@@@@@@@@@@@@";
                    break;
            }
        }

        private string tipo_r(string instrucao, string sep)
        {
            //Ex ADD $X, $Y, $Z
            string[] campos = instrucao.ToLower().Split(' ');
            string Inst = campos[0];
            string X = campos[1].Remove(campos[1].Length - 1).Remove(0, 1);//tira vírgula
            string Y = campos[2].Remove(campos[2].Length - 1).Remove(0, 1);//tira vírgula
            string Z = campos[3].Remove(0, 1);
            string FUNCT = "@@@@@@";

            switch (Inst)
            {
                case "add":
                    FUNCT = "100000";
                    Status = "Conversão efetuada com sucesso";
                    break;
                case "sub":
                    FUNCT = "100010";
                    Status = "Conversão efetuada com sucesso";
                    break;
                case "and":
                    FUNCT = "100100";
                    Status = "Conversão efetuada com sucesso";
                    break;
                case "or":
                    FUNCT = "100101";
                    Status = "Conversão efetuada com sucesso";
                    break;
                case "slt":
                    FUNCT = "101010";
                    Status = "Conversão efetuada com sucesso";
                    break;
                default:
                    Status = "Instrução não suportada";
                    flag_error = true;
                    break;
            }

            //OP RS RT RD SHAMT FUNCT
            return "000000" + sep + hex2binary(Y).PadLeft(5, '0') + sep + hex2binary(Z).PadLeft(5, '0') + sep + hex2binary(X).PadLeft(5, '0') + sep + "00000" + sep + FUNCT;
        }

        private string tipo_i(string instrucao, string sep)
        {
            //Ex ADDi $X, $Y, i
            string[] campos = instrucao.ToLower().Split(' ');
            string Inst = campos[0];
            string X = campos[1].Remove(campos[1].Length - 1).Remove(0, 1);//tira vírgula
            string Y = campos[2].Remove(campos[2].Length - 1).Remove(0, 1);//tira vírgula
            string i = campos[3];
            string cod_maq = "@@@@@@_@@@@@_@@@@@_@@@@@@@@@@@@@@@@";

            switch (Inst)
            {
                case "addi":
                    cod_maq = "001000" + sep + hex2binary(Y).PadLeft(5, '0') + sep + hex2binary(X).PadLeft(5, '0') + sep + hex2binary(i).PadLeft(16, '0');
                    Status = "Conversão efetuada com sucesso";
                    break;
                case "beq":
                    cod_maq = "000100" + sep + hex2binary(X).PadLeft(5, '0') + sep + hex2binary(Y).PadLeft(5, '0') + sep + hex2binary(i).PadLeft(16, '0');
                    Status = "Conversão efetuada com sucesso";
                    break;
                default:
                    Status = "Instrução não suportada";
                    flag_error = true;
                    break;
            }

            return cod_maq;
        }

        private string tipo_mem(string instrucao, string sep)
        {
            //Ex LW $X, i($Y)
            string[] campos = instrucao.ToLower().Split(' ');
            string Inst = campos[0];
            string X = campos[1].Remove(campos[1].Length - 1).Remove(0, 1);//tira vírgula
            string[] iY = campos[2].Split('(');//tira vírgula
            string i = iY[0];
            string Y = iY[1].Remove(iY[1].Length - 1).Remove(0, 1);
            string OP = "@@@@@@";

            switch (Inst)
            {
                case "lw":
                    OP = "100011";
                    Status = "Conversão efetuada com sucesso";
                    break;
                case "sw":
                    OP = "101011";
                    Status = "Conversão efetuada com sucesso";
                    break;
                default:
                    Status = "Instrução não suportada";
                    flag_error = true;
                    break;
            }

            return OP + sep + hex2binary(Y).PadLeft(5, '0') + sep + hex2binary(X).PadLeft(5, '0') + sep + hex2binary(i).PadLeft(16, '0');
        }

        private string tipo_j(string instrucao, string sep)
        {
            //Ex j i
            string[] campos = instrucao.ToLower().Split(' ');
            string Inst = campos[0];
            string i = campos[1];
            Status = "Conversão efetuada com sucesso"; 

            return "000010" + sep + hex2binary(i).PadLeft(26, '0');
        }

        private string hex2binary(string hexvalue)
        {
            string binaryval = "";
            binaryval = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
            return binaryval;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sep.Checked == true)
                sep = "_";
            else
                sep = "";
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UFCG - UAEE\nLab. de Arquitetura de Sistemas Digitais - Prof. Rafael Lima\nMIPS Assembler V1.3");
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instruções suportadas:\n\n" +
                "ADD $X, $Y, $Z" + "\n" +
                "SUB $X, $Y, $Z" + "\n" +
                "AND $X, $Y, $Z" + "\n" +
                "OR $X, $Y, $Z" + "\n" +
                "SLT $X, $Y, $Z" + "\n" +
                "LW $X, i($Y)" + "\n" +
                "SW $X, i($Y)" + "\n" +
                "BEQ $X, $Y, i" + "\n" +
                "ADDi $X, $Y, i" + "\n" +
                "J i" + "\n" + "\n" +
                "\nResistradores: \n\n$0, $1, $2, $3, $4, $5, $6, $7" + 
                "\nObs: Usar o $ antes do registrador,\nespaço simples e vírgula." +
                "\nTodas as constantes são assumidas em hexa.");
        }

        private void configuraçõesDoMifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText MifName_form = new InputText();
            MifName_form.Mif_name = mif_name;
            MifName_form.ShowDialog();
            if (MifName_form.DialogResult == DialogResult.OK)
            {
                mif_name = MifName_form.Mif_name;
            }
        }

        private void abrirmifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string loaded_mif;
                string[] splitted_mif;

                if (openFileDialog_mif.ShowDialog() == DialogResult.OK)
                {
                    loaded_mif = System.IO.File.ReadAllText(openFileDialog_mif.FileName);
                    splitted_mif = loaded_mif.Split('#');
                    richTextBox_MIPS.Text = splitted_mif[2].TrimStart().TrimEnd();
                    richTextBox_comentarios.Text = splitted_mif[4].TrimStart();
                    richTextBox_cod_maq.Text = "";
                }
                
            }
            catch
            {
                Status = "Erro ao abrir o arquivo .mif";
                MessageBox.Show("Erro ao abrir o arquivo .mif. Possivelmente formato inválido. Só é possível carregar um .mif gerado a partir desse mesmo aplicativo.");
            }

        }
    }
}
