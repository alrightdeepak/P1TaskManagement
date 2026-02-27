using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace TaskManagement.Controls
{
    public class ModernTextBox : UserControl
    {
        private TextBox textBox = new TextBox();

        private Color borderColor = Color.Silver;
        private Color focusColor = Color.DodgerBlue;
        private int borderSize = 2;
        private bool isFocused = false;

        public ModernTextBox()
        {
            this.DoubleBuffered = true;
            this.Padding = new Padding(0, 0, 0, 5);
            this.BackColor = Color.White;
            this.Size = new Size(200, 30);

            // Inner textbox
            textBox.BorderStyle = BorderStyle.None;
            textBox.Location = new Point(0, 5);
            textBox.Width = this.Width;
            textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            textBox.Font = new Font("Segoe UI", 10f);

            textBox.Enter += (s, e) =>
            {
                isFocused = true;
                this.Invalidate();
            };

            textBox.Leave += (s, e) =>
            {
                isFocused = false;
                this.Invalidate();
            };

            this.Controls.Add(textBox);

            this.Resize += (s, e) =>
            {
                textBox.Width = this.Width;
            };
        }

        // Expose Text property
        [Browsable(true)]
        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        // Border color (inactive)
        [Category("Modern UI")]
        [Description("Border color when not focused")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Modern UI")]
        [Description("Border color when textbox is focused")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color FocusColor
        {
            get => focusColor;
            set
            {
                focusColor = value;
                Invalidate();
            }
        }

        [Category("Modern UI")]
        [Description("Bottom border thickness")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                Invalidate();
            }
        }
        [Category("Modern UI")]
        [Description("Placeholder text shown when empty")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PlaceholderText
        {
            get => textBox.PlaceholderText;
            set => textBox.PlaceholderText = value;
        }
        [Category("Behavior")]
        [Description("Indicates whether the text should appear as password characters.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool UseSystemPasswordChar
        {
            get => textBox.UseSystemPasswordChar;
            set => textBox.UseSystemPasswordChar = value;
        }
        [Category("Behavior")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int MaxLength
        {
            get => textBox.MaxLength;
            set => textBox.MaxLength = value;
        }
        public void Clear()
        {
            this.Text = string.Empty;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(isFocused ? focusColor : borderColor, borderSize))
            {
                e.Graphics.SmoothingMode =
                    System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Draw bottom line
                e.Graphics.DrawLine(
                    pen,
                    0,
                    this.Height - 1,
                    this.Width,
                    this.Height - 1);
            }
        }
    }
}