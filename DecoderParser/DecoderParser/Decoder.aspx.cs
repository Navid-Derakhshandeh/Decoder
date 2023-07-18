using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DecoderParser
{
    public partial class Decoder : System.Web.UI.Page
    {
        public void lexicalanalyzer()
        {
            Regex Decoder = new Regex("[abcdefghijklmnopqrstuvwxyz][-+/]", RegexOptions.IgnoreCase);
            MatchCollection z = Decoder.Matches(this.TextBox1.Text);

            foreach (Match a in z)
            {
                if (a.Value.StartsWith("z"))
                    ListBox1.Items.Add($"a");
                if (a.Value.StartsWith("w"))
                    ListBox1.Items.Add($"b");
                if (a.Value.StartsWith("u"))
                    ListBox1.Items.Add($"c");
                if (a.Value.StartsWith("s"))
                    ListBox1.Items.Add($"d");
                if (a.Value.StartsWith("q"))
                    ListBox1.Items.Add($"e");
                if (a.Value.StartsWith("p"))
                    ListBox1.Items.Add($"f");
                if (a.Value.StartsWith("n+"))
                    ListBox1.Items.Add($"g");
                if (a.Value.StartsWith("l"))
                    ListBox1.Items.Add($"h");
                if (a.Value.StartsWith("j"))
                    ListBox1.Items.Add($"i");
                if (a.Value.StartsWith("g/"))
                    ListBox1.Items.Add($"j");
                if (a.Value.StartsWith("f"))
                    ListBox1.Items.Add($"k");
                if (a.Value.StartsWith("c"))
                    ListBox1.Items.Add($"l");
                if (a.Value.StartsWith("b"))
                    ListBox1.Items.Add($"m");
                if (a.Value.StartsWith("a"))
                    ListBox1.Items.Add($"n");
                if (a.Value.StartsWith("y"))
                    ListBox1.Items.Add($"o");
                if (a.Value.StartsWith("x"))
                    ListBox1.Items.Add($"p");
                if (a.Value.StartsWith("r+"))
                    ListBox1.Items.Add($"q");
                if (a.Value.StartsWith("e+"))
                    ListBox1.Items.Add($"r");
                if (a.Value.StartsWith("u"))
                    ListBox1.Items.Add($"s");
                if (a.Value.StartsWith("h"))
                    ListBox1.Items.Add($"t");
                if (a.Value.StartsWith("v"))
                    ListBox1.Items.Add($"u");
                if (a.Value.StartsWith("i+"))
                    ListBox1.Items.Add($"v");
                if (a.Value.StartsWith("r/"))
                    ListBox1.Items.Add($"w");
                if (a.Value.StartsWith("e/"))
                    ListBox1.Items.Add($"x");
                if (a.Value.StartsWith("k"))
                    ListBox1.Items.Add($"y");
                if (a.Value.StartsWith("m"))
                    ListBox1.Items.Add($"z");
                if (a.Value.StartsWith("n/"))
                    ListBox1.Items.Add($".");
                if (a.Value.StartsWith("i/"))
                    ListBox1.Items.Add($",");

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lexicalanalyzer();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}