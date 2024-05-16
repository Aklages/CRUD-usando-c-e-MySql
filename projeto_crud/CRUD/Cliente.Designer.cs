namespace CRUD
{
	partial class Cliente
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnCreate = new Button();
			btnRead = new Button();
			btnUpdate = new Button();
			btnDelete = new Button();
			txtNom = new TextBox();
			lblNom = new Label();
			lblTel = new Label();
			txtTel = new TextBox();
			lblEnd = new Label();
			txtEnd = new TextBox();
			lblCpf = new Label();
			txtCpf = new TextBox();
			SuspendLayout();
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(127, 264);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(209, 42);
			btnCreate.TabIndex = 0;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += button1_Click;
			// 
			// btnRead
			// 
			btnRead.Location = new Point(342, 264);
			btnRead.Name = "btnRead";
			btnRead.Size = new Size(209, 42);
			btnRead.TabIndex = 1;
			btnRead.Text = "Read";
			btnRead.UseVisualStyleBackColor = true;
			btnRead.Click += button2_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(126, 312);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(209, 42);
			btnUpdate.TabIndex = 2;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(342, 312);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(209, 42);
			btnDelete.TabIndex = 3;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// txtNom
			// 
			txtNom.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			txtNom.Location = new Point(203, 84);
			txtNom.Name = "txtNom";
			txtNom.Size = new Size(348, 31);
			txtNom.TabIndex = 4;
			// 
			// lblNom
			// 
			lblNom.AutoSize = true;
			lblNom.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			lblNom.Location = new Point(126, 86);
			lblNom.Name = "lblNom";
			lblNom.Size = new Size(61, 25);
			lblNom.TabIndex = 5;
			lblNom.Text = "Nome";
			// 
			// lblTel
			// 
			lblTel.AutoSize = true;
			lblTel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			lblTel.Location = new Point(126, 125);
			lblTel.Name = "lblTel";
			lblTel.Size = new Size(77, 25);
			lblTel.TabIndex = 7;
			lblTel.Text = "Telefone";
			// 
			// txtTel
			// 
			txtTel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			txtTel.Location = new Point(209, 123);
			txtTel.Name = "txtTel";
			txtTel.Size = new Size(342, 31);
			txtTel.TabIndex = 6;
			// 
			// lblEnd
			// 
			lblEnd.AutoSize = true;
			lblEnd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			lblEnd.Location = new Point(126, 162);
			lblEnd.Name = "lblEnd";
			lblEnd.Size = new Size(85, 25);
			lblEnd.TabIndex = 9;
			lblEnd.Text = "Endereço";
			// 
			// txtEnd
			// 
			txtEnd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			txtEnd.Location = new Point(217, 160);
			txtEnd.Name = "txtEnd";
			txtEnd.Size = new Size(334, 31);
			txtEnd.TabIndex = 8;
			// 
			// lblCpf
			// 
			lblCpf.AutoSize = true;
			lblCpf.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			lblCpf.Location = new Point(126, 201);
			lblCpf.Name = "lblCpf";
			lblCpf.Size = new Size(42, 25);
			lblCpf.TabIndex = 11;
			lblCpf.Text = "CPF";
			// 
			// txtCpf
			// 
			txtCpf.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			txtCpf.Location = new Point(176, 198);
			txtCpf.Name = "txtCpf";
			txtCpf.Size = new Size(375, 31);
			txtCpf.TabIndex = 10;
			// 
			// Cliente
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(686, 390);
			Controls.Add(lblCpf);
			Controls.Add(txtCpf);
			Controls.Add(lblEnd);
			Controls.Add(txtEnd);
			Controls.Add(lblTel);
			Controls.Add(txtTel);
			Controls.Add(lblNom);
			Controls.Add(txtNom);
			Controls.Add(btnDelete);
			Controls.Add(btnUpdate);
			Controls.Add(btnRead);
			Controls.Add(btnCreate);
			Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
			Name = "Cliente";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCreate;
		private Button btnRead;
		private Button btnUpdate;
		private Button btnDelete;
		private TextBox txtNom;
		private Label lblNom;
		private Label lblTel;
		private TextBox txtTel;
		private Label lblEnd;
		private TextBox txtEnd;
		private Label lblCpf;
		private TextBox txtCpf;
	}
}
