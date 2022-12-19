using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            try
            {
                flag_error = false;

                //Remover linhas vazias do código assembly
                richTextBox_MIPS.Text = Regex.Replace(richTextBox_MIPS.Text, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd();

                //Converter para o richtextbox de código de máquina
                richTextBox_cod_maq.Text = "";
                foreach (string element in richTextBox_MIPS.Lines)
                {
                    richTextBox_cod_maq.Text += assembler_mips(element, sep) + "\n";
                }

                //Escrever no arquivo. OBS converte novamente (sub ótimo)
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
            catch(System.FormatException fe)
            {
                var st = new StackTrace(fe, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                Console.WriteLine("line: " + line + "erro: " + fe.ToString());     
            }
            catch
            {
                Status = "Instrução não suportada ou formato inválido";
                MessageBox.Show("Instrução não suportada ou formato inválido!\nVerifique se ficou algum espaço ou linha em branco.");
            }
            
        }

        private string assembler_mips(string instrucao, string sep)
        {
           
            string[] campos = Regex.Split(instrucao.ToLower(), @"[, ]+");
            instrucao = String.Join(" ", campos);   
            
            Console.WriteLine(campos.Length + " > " + instrucao);
            string Inst = campos[0];

            switch (Inst)
            {   
                //Tipo R***************************
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
                case "nor":
                    return tipo_r(instrucao, sep);
                    break;
                case "xor":
                    return tipo_r(instrucao, sep);
                    break;
                case "slt":
                    return tipo_r(instrucao, sep);
                    break;
                case "sll":
                    return tipo_r(instrucao, sep);
                    break;
                case "srl":
                    return tipo_r(instrucao, sep);
                    break;
                case "sra":
                    return tipo_r(instrucao, sep);
                    break;
                case "sllv":
                    return tipo_r(instrucao, sep);
                    break;
                case "srlv":
                    return tipo_r(instrucao, sep);
                    break;
                case "srav":
                    return tipo_r(instrucao, sep);
                    break;
                //Tipo I***************************
                case "addi":
                    return tipo_i(instrucao, sep);
                    break;
                case "andi":
                    return tipo_i(instrucao, sep);
                    break;
                case "ori":
                    return tipo_i(instrucao, sep);
                    break;
                case "slti":
                    return tipo_i(instrucao, sep);
                    break;
                case "beq":
                    return tipo_i(instrucao, sep);
                    break;
                //Tipo "MEM"***********************
                case "lw":
                    return tipo_mem(instrucao, sep);
                    break;
                case "sw":
                    return tipo_mem(instrucao, sep);
                    break;
                //Tipo J***************************
                case "j":
                    return tipo_j(instrucao, sep);
                    break;
                case "jal":
                    return tipo_j(instrucao, sep);
                    break;
                //NOP - No operation **************
                case "nop":
                    return "000000" + sep + "00000" + sep + "00000" + sep + "00000" + sep + "00000" + sep + "100000"; //ADD $0, $0, $0
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
            ///Ex ADD $X, $Y, $Z
            /// Instr rd, rs, rt|SHAMT
            string[] campos = instrucao.ToLower().Split(' ');
            
            string Inst = campos[0];
            string X = campos[1].Replace("$", "");  // rd
            string Y = campos[2].Replace("$", "");  // rs
            string Z = campos[3].Replace("$", "");  // rt
            string FUNCT = "@@@@@@";
            string SHAMT = "00000";
            Console.WriteLine($"inst: {Inst} x:{X} y:{Y} z:{Z}");

            string Temp = ""; // variável auxiliar para trocar rs e rt
            Status = "Conversão efetuada com sucesso";
            switch (Inst)
            {
                case "add":
                    FUNCT = "100000";
                    break;
                case "sub":
                    FUNCT = "100010";
                    break;
                case "and":
                    FUNCT = "100100";
                    break;
                case "or":
                    FUNCT = "100101";
                    break;
                case "nor":
                    FUNCT = "100111";
                    break;
                case "xor":
                    FUNCT = "100110";
                    break;
                case "slt":
                    FUNCT = "101010";
                    break;
                case "sll":
                    FUNCT = "000000";
                    SHAMT = Z;
                    Z = Y;
                    Y = "0";
                    break;
                case "srl":
                    FUNCT = "000010";
                    SHAMT = Z;
                    Z = Y;
                    Y = "0";
                    break;
                case "sra":
                    FUNCT = "000011";
                    SHAMT = Z;
                    Z = Y;
                    Y = "0";
                    break;
                case "sllv":
                    FUNCT = "000100";
                    Temp = Y;
                    Y = Z;
                    Z = Temp;
                    break;
                case "srlv":
                    FUNCT = "000110";
                    Temp = Y;
                    Y = Z;
                    Z = Temp;
                    break;
                case "srav":
                    FUNCT = "000111";
                    Temp = Y;
                    Y = Z;
                    Z = Temp;
                    break;
                default:
                    Status = $"Instrução não suportada ({Inst})";
                    flag_error = true;
                    break;
            }

            //OP RS RT RD SHAMT FUNCT
            return "000000" + sep + hex2binary(Y).PadLeft(5, '0') + sep + hex2binary(Z).PadLeft(5, '0') + sep + hex2binary(X).PadLeft(5, '0') + sep + hex2binary(SHAMT).PadLeft(5, '0') + sep + FUNCT;
        }

        private string tipo_i(string instrucao, string sep)
        {
            //Ex ADDi $X, $Y, i
            string[] campos = instrucao.ToLower().Split(' ');
            string Inst = campos[0];
            string X = campos[1].Remove(0, 1);
            string Y = campos[2].Remove(0, 1);
            string i = campos[3];
            string cod_maq = "@@@@@@_@@@@@_@@@@@_@@@@@@@@@@@@@@@@";

            switch (Inst)
            {
                case "addi":
                    cod_maq = "001000" + sep + hex2binary(Y).PadLeft(5, '0') + sep + hex2binary(X).PadLeft(5, '0') + sep + hex2binary(i).PadLeft(16, '0');
                    Status = "Conversão efetuada com sucesso";
                    break;
                case "andi":
                    cod_maq = "001100" + sep + hex2binary(Y).PadLeft(5, '0') + sep + hex2binary(X).PadLeft(5, '0') + sep + hex2binary(i).PadLeft(16, '0');
                    Status = "Conversão efetuada com sucesso";
                    break;
                case "ori":
                    cod_maq = "001101" + sep + hex2binary(Y).PadLeft(5, '0') + sep + hex2binary(X).PadLeft(5, '0') + sep + hex2binary(i).PadLeft(16, '0');
                    Status = "Conversão efetuada com sucesso";
                    break;
                case "slti":
                    cod_maq = "001010" + sep + hex2binary(Y).PadLeft(5, '0') + sep + hex2binary(X).PadLeft(5, '0') + sep + hex2binary(i).PadLeft(16, '0');
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
            string X = campos[1].Remove(0, 1);//tira vírgula
            string[] iY = campos[2].Split('(');//tira vírgula
            string i = iY[0];
            string Y = iY[1].Remove(iY[1].Length-1, 1).Remove(0, 1);
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
            //Ex j i e jal i
            string[] campos = instrucao.ToLower().Split(' ');
            string Inst = campos[0];
            string i = campos[1];
            string OP = "@@@@@@";

            switch (Inst)
            {
                case "j":
                    OP = "000010";
                    Status = "Conversão efetuada com sucesso";
                    break;
                case "jal":
                    OP = "000011";
                    Status = "Conversão efetuada com sucesso";
                    break;
                default:
                    Status = "Instrução não suportada";
                    flag_error = true;
                    break;
            }
            return OP + sep + hex2binary(i).PadLeft(26, '0'); 
        }

        private string hex2binary(string hexvalue)
        {
            string binaryval = "";
            Console.WriteLine("hex: " + hexvalue);
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
            MessageBox.Show("UFCG - UAEE\nLab. de Arquitetura de Sistemas Digitais - Prof. Rafael Lima\nMIPS Assembler V1.5");
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instruções suportadas:\n\n" +
                "ADD $X, $Y, $Z"    + "\t $X = $Y + $Z\n" +
                "SUB $X, $Y, $Z"    + "\t $X = $Y + ~$Z +1\n" +
                "AND $X, $Y, $Z"    + "\t $X = $Y & $Z\n" +
                "OR $X, $Y, $Z"     + "\t $X = $Y | $Z\n" +
                "NOR $X, $Y, $Z"    + "\t $X = ~($Y | $Z)\n" +
                "XOR $X, $Y, $Z"    + "\t $X = $Y ^ $Z\n" +
                "SLT $X, $Y, $Z"    + "\t $X = 1 se $Y < $Z e 0 c.c.\n" +
                "SLL $X, $Y, shamt" + "\t $X = $Y << shamt\n" +
                "SRL $X, $Y, shamt" + "\t $X = $Y >> shamt\n" +
                "SRA $X, $Y, shamt" + "\t $X = $Y >>> shamt\n" +
                "SLLv $X, $Y, $Z"   + "\t $X = $Y << $Z\n" +
                "SRLv $X, $Y, $Z"   + "\t $X = $Y >> $Z\n" +
                "SRAv $X, $Y, $Z"   + "\t $X = $Y >>> $Z\n" +
                "LW $X, i($Y)"      + "\t $X <= Cont. do end. ($Y+ i)\n" +
                "SW $X, i($Y)"      + "\t End. ($Y+ i) <= $X\n" +
                "BEQ $X, $Y, i"     + "\t Se $X == $Y, PC = PC + 1 + i\n" +
                "ADDi $X, $Y, i"    + "\t $X = $Y + i\n" +
                "ANDi $X, $Y, i"    + "\t $X = $Y & i\n" +
                "ORi $X, $Y, i"     + "\t $X = $Y | i\n" +
                "SLTi $X, $Y, i"    + "\t $X = 1 se $Y < i e 0 c.c.\n" +
                "J i"               + "\t \t PC = i\n" +
                "JAL i"             + "\t \t $7 = PC+1 e PC = i\n" +
                "NOP"               + "\t \t No operation\n" + "\n" +
                "\nRegistradores: \n\n$0, $1, $2, $3, $4, $5, $6, $7" + 
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

        private void richTextBox_MIPS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
