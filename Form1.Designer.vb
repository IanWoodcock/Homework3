<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gpbxFoodChoices = New System.Windows.Forms.GroupBox()
        Me.rbtnFruit = New System.Windows.Forms.RadioButton()
        Me.rbtnSausageAndCheese = New System.Windows.Forms.RadioButton()
        Me.rbtnVeggie = New System.Windows.Forms.RadioButton()
        Me.rbtnWraps = New System.Windows.Forms.RadioButton()
        Me.rbtnGCheese = New System.Windows.Forms.RadioButton()
        Me.gpbxPayOptions = New System.Windows.Forms.GroupBox()
        Me.rbtnPickupPay = New System.Windows.Forms.RadioButton()
        Me.rbtnPrePay = New System.Windows.Forms.RadioButton()
        Me.picFood = New System.Windows.Forms.PictureBox()
        Me.lblLoyaltyPts = New System.Windows.Forms.Label()
        Me.txtPts = New System.Windows.Forms.TextBox()
        Me.lblCatering = New System.Windows.Forms.Label()
        Me.lblStarMarket = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.gpbxFoodChoices.SuspendLayout()
        Me.gpbxPayOptions.SuspendLayout()
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbxFoodChoices
        '
        Me.gpbxFoodChoices.BackColor = System.Drawing.Color.Linen
        Me.gpbxFoodChoices.Controls.Add(Me.rbtnFruit)
        Me.gpbxFoodChoices.Controls.Add(Me.rbtnSausageAndCheese)
        Me.gpbxFoodChoices.Controls.Add(Me.rbtnVeggie)
        Me.gpbxFoodChoices.Controls.Add(Me.rbtnWraps)
        Me.gpbxFoodChoices.Controls.Add(Me.rbtnGCheese)
        Me.gpbxFoodChoices.Location = New System.Drawing.Point(44, 88)
        Me.gpbxFoodChoices.Name = "gpbxFoodChoices"
        Me.gpbxFoodChoices.Size = New System.Drawing.Size(327, 188)
        Me.gpbxFoodChoices.TabIndex = 0
        Me.gpbxFoodChoices.TabStop = False
        '
        'rbtnFruit
        '
        Me.rbtnFruit.AutoSize = True
        Me.rbtnFruit.Location = New System.Drawing.Point(6, 158)
        Me.rbtnFruit.Name = "rbtnFruit"
        Me.rbtnFruit.Size = New System.Drawing.Size(85, 19)
        Me.rbtnFruit.TabIndex = 4
        Me.rbtnFruit.Text = "Fruit $29.99"
        Me.rbtnFruit.UseVisualStyleBackColor = True
        '
        'rbtnSausageAndCheese
        '
        Me.rbtnSausageAndCheese.AutoSize = True
        Me.rbtnSausageAndCheese.Location = New System.Drawing.Point(6, 122)
        Me.rbtnSausageAndCheese.Name = "rbtnSausageAndCheese"
        Me.rbtnSausageAndCheese.Size = New System.Drawing.Size(168, 19)
        Me.rbtnSausageAndCheese.TabIndex = 3
        Me.rbtnSausageAndCheese.Text = "Sausage and Cheese $49.99"
        Me.rbtnSausageAndCheese.UseVisualStyleBackColor = True
        '
        'rbtnVeggie
        '
        Me.rbtnVeggie.AutoSize = True
        Me.rbtnVeggie.Location = New System.Drawing.Point(6, 85)
        Me.rbtnVeggie.Name = "rbtnVeggie"
        Me.rbtnVeggie.Size = New System.Drawing.Size(96, 19)
        Me.rbtnVeggie.TabIndex = 2
        Me.rbtnVeggie.Text = "Veggie $29.99"
        Me.rbtnVeggie.UseVisualStyleBackColor = True
        '
        'rbtnWraps
        '
        Me.rbtnWraps.AutoSize = True
        Me.rbtnWraps.Location = New System.Drawing.Point(6, 49)
        Me.rbtnWraps.Name = "rbtnWraps"
        Me.rbtnWraps.Size = New System.Drawing.Size(145, 19)
        Me.rbtnWraps.TabIndex = 1
        Me.rbtnWraps.Text = "Pinwheel Wraps $59.99"
        Me.rbtnWraps.UseVisualStyleBackColor = True
        '
        'rbtnGCheese
        '
        Me.rbtnGCheese.AutoSize = True
        Me.rbtnGCheese.Checked = True
        Me.rbtnGCheese.Location = New System.Drawing.Point(6, 11)
        Me.rbtnGCheese.Name = "rbtnGCheese"
        Me.rbtnGCheese.Size = New System.Drawing.Size(149, 19)
        Me.rbtnGCheese.TabIndex = 0
        Me.rbtnGCheese.TabStop = True
        Me.rbtnGCheese.Text = "Gourmet Cheese $49.99"
        Me.rbtnGCheese.UseVisualStyleBackColor = True
        '
        'gpbxPayOptions
        '
        Me.gpbxPayOptions.BackColor = System.Drawing.Color.Linen
        Me.gpbxPayOptions.Controls.Add(Me.rbtnPickupPay)
        Me.gpbxPayOptions.Controls.Add(Me.rbtnPrePay)
        Me.gpbxPayOptions.Location = New System.Drawing.Point(110, 297)
        Me.gpbxPayOptions.Name = "gpbxPayOptions"
        Me.gpbxPayOptions.Size = New System.Drawing.Size(190, 68)
        Me.gpbxPayOptions.TabIndex = 1
        Me.gpbxPayOptions.TabStop = False
        '
        'rbtnPickupPay
        '
        Me.rbtnPickupPay.AutoSize = True
        Me.rbtnPickupPay.Location = New System.Drawing.Point(7, 37)
        Me.rbtnPickupPay.Name = "rbtnPickupPay"
        Me.rbtnPickupPay.Size = New System.Drawing.Size(114, 19)
        Me.rbtnPickupPay.TabIndex = 1
        Me.rbtnPickupPay.Text = "Pay upon pickup"
        Me.rbtnPickupPay.UseVisualStyleBackColor = True
        '
        'rbtnPrePay
        '
        Me.rbtnPrePay.AutoSize = True
        Me.rbtnPrePay.Checked = True
        Me.rbtnPrePay.Location = New System.Drawing.Point(7, 12)
        Me.rbtnPrePay.Name = "rbtnPrePay"
        Me.rbtnPrePay.Size = New System.Drawing.Size(66, 19)
        Me.rbtnPrePay.TabIndex = 0
        Me.rbtnPrePay.TabStop = True
        Me.rbtnPrePay.Text = "Pre-Pay"
        Me.rbtnPrePay.UseVisualStyleBackColor = True
        '
        'picFood
        '
        Me.picFood.Image = CType(resources.GetObject("picFood.Image"), System.Drawing.Image)
        Me.picFood.Location = New System.Drawing.Point(402, 12)
        Me.picFood.Name = "picFood"
        Me.picFood.Size = New System.Drawing.Size(386, 208)
        Me.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFood.TabIndex = 2
        Me.picFood.TabStop = False
        '
        'lblLoyaltyPts
        '
        Me.lblLoyaltyPts.AutoSize = True
        Me.lblLoyaltyPts.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLoyaltyPts.Location = New System.Drawing.Point(469, 255)
        Me.lblLoyaltyPts.Name = "lblLoyaltyPts"
        Me.lblLoyaltyPts.Size = New System.Drawing.Size(122, 21)
        Me.lblLoyaltyPts.TabIndex = 3
        Me.lblLoyaltyPts.Text = "Loyalty Points:"
        '
        'txtPts
        '
        Me.txtPts.Location = New System.Drawing.Point(597, 253)
        Me.txtPts.Name = "txtPts"
        Me.txtPts.Size = New System.Drawing.Size(40, 23)
        Me.txtPts.TabIndex = 5
        '
        'lblCatering
        '
        Me.lblCatering.AutoSize = True
        Me.lblCatering.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCatering.Location = New System.Drawing.Point(99, 9)
        Me.lblCatering.Name = "lblCatering"
        Me.lblCatering.Size = New System.Drawing.Size(106, 28)
        Me.lblCatering.TabIndex = 6
        Me.lblCatering.Text = "Catering"
        '
        'lblStarMarket
        '
        Me.lblStarMarket.AutoSize = True
        Me.lblStarMarket.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStarMarket.Location = New System.Drawing.Point(82, 47)
        Me.lblStarMarket.Name = "lblStarMarket"
        Me.lblStarMarket.Size = New System.Drawing.Size(96, 19)
        Me.lblStarMarket.TabIndex = 7
        Me.lblStarMarket.Text = "Star Market"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Bisque
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(449, 297)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(99, 31)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Bisque
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(597, 297)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 31)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPay.Location = New System.Drawing.Point(110, 392)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(86, 20)
        Me.lblPay.TabIndex = 11
        Me.lblPay.Text = "Please Pay:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOutput.Location = New System.Drawing.Point(218, 392)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 20)
        Me.lblOutput.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblStarMarket)
        Me.Controls.Add(Me.lblCatering)
        Me.Controls.Add(Me.txtPts)
        Me.Controls.Add(Me.lblLoyaltyPts)
        Me.Controls.Add(Me.picFood)
        Me.Controls.Add(Me.gpbxPayOptions)
        Me.Controls.Add(Me.gpbxFoodChoices)
        Me.Name = "Form1"
        Me.Text = "Catering"
        Me.gpbxFoodChoices.ResumeLayout(False)
        Me.gpbxFoodChoices.PerformLayout()
        Me.gpbxPayOptions.ResumeLayout(False)
        Me.gpbxPayOptions.PerformLayout()
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbxFoodChoices As GroupBox
    Friend WithEvents rbtnFruit As RadioButton
    Friend WithEvents rbtnSausageAndCheese As RadioButton
    Friend WithEvents rbtnVeggie As RadioButton
    Friend WithEvents rbtnWraps As RadioButton
    Friend WithEvents rbtnGCheese As RadioButton
    Friend WithEvents gpbxPayOptions As GroupBox
    Friend WithEvents rbtnPickupPay As RadioButton
    Friend WithEvents rbtnPrePay As RadioButton
    Friend WithEvents picFood As PictureBox
    Friend WithEvents lblLoyaltyPts As Label
    Friend WithEvents txtPts As TextBox
    Friend WithEvents lblCatering As Label
    Friend WithEvents lblStarMarket As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPay As Label
    Friend WithEvents lblOutput As Label
End Class
