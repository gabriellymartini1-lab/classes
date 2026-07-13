namespace login_2
{
    partial class cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            uiLabel1 = new Sunny.UI.UILabel();
            tb_genero = new Sunny.UI.UITextBox();
            tb_idade = new Sunny.UI.UITextBox();
            tb_nome = new Sunny.UI.UITextBox();
            btn_cadastrar = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("Muthiara -Demo Version-", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.White;
            uiLabel1.Location = new Point(213, 69);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(374, 51);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "Sistema de Cadastro";
            // 
            // tb_genero
            // 
            tb_genero.BackColor = Color.Transparent;
            tb_genero.Font = new Font("Microsoft Sans Serif", 12F);
            tb_genero.Location = new Point(213, 227);
            tb_genero.Margin = new Padding(4, 5, 4, 5);
            tb_genero.MinimumSize = new Size(1, 16);
            tb_genero.Name = "tb_genero";
            tb_genero.Padding = new Padding(5);
            tb_genero.Radius = 29;
            tb_genero.RectColor = Color.Transparent;
            tb_genero.ScrollBarBackColor = Color.Transparent;
            tb_genero.ScrollBarStyleInherited = false;
            tb_genero.ShowText = false;
            tb_genero.Size = new Size(374, 29);
            tb_genero.TabIndex = 3;
            tb_genero.TextAlignment = ContentAlignment.MiddleLeft;
            tb_genero.Watermark = "gênero";
            // 
            // tb_idade
            // 
            tb_idade.BackColor = Color.Transparent;
            tb_idade.Font = new Font("Microsoft Sans Serif", 12F);
            tb_idade.Location = new Point(213, 188);
            tb_idade.Margin = new Padding(4, 5, 4, 5);
            tb_idade.MinimumSize = new Size(1, 16);
            tb_idade.Name = "tb_idade";
            tb_idade.Padding = new Padding(5);
            tb_idade.Radius = 29;
            tb_idade.RectColor = Color.Transparent;
            tb_idade.ScrollBarBackColor = Color.Transparent;
            tb_idade.ScrollBarStyleInherited = false;
            tb_idade.ShowText = false;
            tb_idade.Size = new Size(374, 29);
            tb_idade.TabIndex = 5;
            tb_idade.TextAlignment = ContentAlignment.MiddleLeft;
            tb_idade.Watermark = "idade";
            // 
            // tb_nome
            // 
            tb_nome.BackColor = Color.Transparent;
            tb_nome.Font = new Font("Microsoft Sans Serif", 12F);
            tb_nome.Location = new Point(213, 149);
            tb_nome.Margin = new Padding(4, 5, 4, 5);
            tb_nome.MinimumSize = new Size(1, 16);
            tb_nome.Name = "tb_nome";
            tb_nome.Padding = new Padding(5);
            tb_nome.Radius = 29;
            tb_nome.RectColor = Color.Transparent;
            tb_nome.ScrollBarBackColor = Color.Transparent;
            tb_nome.ScrollBarStyleInherited = false;
            tb_nome.ShowText = false;
            tb_nome.Size = new Size(374, 29);
            tb_nome.TabIndex = 6;
            tb_nome.TextAlignment = ContentAlignment.MiddleLeft;
            tb_nome.Watermark = "nome";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.Transparent;
            btn_cadastrar.FillColor = Color.PaleVioletRed;
            btn_cadastrar.FillColor2 = Color.Transparent;
            btn_cadastrar.FillDisableColor = Color.White;
            btn_cadastrar.FillHoverColor = Color.PaleVioletRed;
            btn_cadastrar.FillPressColor = Color.PaleVioletRed;
            btn_cadastrar.FillSelectedColor = Color.PaleVioletRed;
            btn_cadastrar.Font = new Font("Muthiara -Demo Version-", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadastrar.LightColor = Color.White;
            btn_cadastrar.Location = new Point(302, 308);
            btn_cadastrar.MinimumSize = new Size(1, 1);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Radius = 30;
            btn_cadastrar.RectColor = Color.Transparent;
            btn_cadastrar.RectHoverColor = Color.PaleVioletRed;
            btn_cadastrar.RectPressColor = Color.PaleVioletRed;
            btn_cadastrar.RectSelectedColor = Color.PaleVioletRed;
            btn_cadastrar.Size = new Size(197, 44);
            btn_cadastrar.TabIndex = 7;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // cadastro
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(248, 248, 248);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            ControlBoxFillHoverColor = Color.FromArgb(163, 163, 163);
            Controls.Add(btn_cadastrar);
            Controls.Add(tb_nome);
            Controls.Add(tb_idade);
            Controls.Add(tb_genero);
            Controls.Add(uiLabel1);
            IconImage = (Image)resources.GetObject("$this.IconImage");
            Name = "cadastro";
            RectColor = Color.FromArgb(140, 140, 140);
            Style = Sunny.UI.UIStyle.Custom;
            Text = "cadastro";
            TitleColor = Color.FromArgb(140, 140, 140);
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += cadastro_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UITextBox lb;
        private Sunny.UI.UITextBox tb_genero;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox tb_idade;
        private Sunny.UI.UITextBox tb_nome;
        private Sunny.UI.UIButton btn_cadastrar;
    }
}