using System;
using System.Reflection;
using System.Windows.Forms;
using sd_lib = System_ds_CommonLibraryCS.libCommon_Common;

namespace GitHub学習用
{
    public partial class F1000 : Form
    {
        public F1000()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算ボタンクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnzan_Click(object sender, EventArgs e)
        {
            double Value1 = 0;
            double Value2 = 0;

            double.TryParse(txtValue1.Text, out Value1);
            double.TryParse(txtValue2.Text, out Value2);

            try
            {
                //選択した演算子により演算処理分岐
                switch(cmbEnzanshi.Text)
                {
                    case "+":

                        //足し算
                        txtEnzan1.Text = (Value1 + Value2).ToString();

                        break;

                    case "-":

                        //引き算
                        txtEnzan1.Text = (Value1 - Value2).ToString();

                        break;

                    case "*":

                        //掛け算
                        txtEnzan1.Text = (Value1 * Value2).ToString();

                        break;

                    case "/":

                        //エラー処理追加 2020/01/24
                        if(Value2== 0)
                        {
                            MessageBox.Show("0で除算する事はできません。", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //割算
                        txtEnzan1.Text = (Value1 / Value2).ToString();

                        break;
                }
            }
            catch (Exception ex)
            {
                sd_lib.ErrorLog_Write("[Object Name]:" + MethodBase.GetCurrentMethod().ReflectedType.Name.ToString() +
                                    "  [Method Name]:" + MethodBase.GetCurrentMethod().Name +
                                    "  [Error kind]:Exception Error" + "\r\n" + ex.Message + "\r\n" + ex.StackTrace, true);
#if DEBUG
                {
                    MessageBox.Show(ex.Message, MethodBase.GetCurrentMethod().ReflectedType.Name.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
#endif
            }
            finally
            {

            }
        }

        /// <summary>
        /// 値クリアボタンクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue1.Text = "";
                txtValue2.Text = "";
                txtEnzan1.Text = "";

                cmbEnzanshi.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                sd_lib.ErrorLog_Write("[Object Name]:" + MethodBase.GetCurrentMethod().ReflectedType.Name.ToString() +
                                    "  [Method Name]:" + MethodBase.GetCurrentMethod().Name +
                                    "  [Error kind]:Exception Error" + "\r\n" + ex.Message + "\r\n" + ex.StackTrace, true);
#if DEBUG
                {
                    MessageBox.Show(ex.Message, MethodBase.GetCurrentMethod().ReflectedType.Name.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
#endif
            }
            finally
            {

            }
        }

        /// <summary>
        /// システム終了ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                sd_lib.ErrorLog_Write("[Object Name]:" + MethodBase.GetCurrentMethod().ReflectedType.Name.ToString() +
                                    "  [Method Name]:" + MethodBase.GetCurrentMethod().Name +
                                    "  [Error kind]:Exception Error" + "\r\n" + ex.Message + "\r\n" + ex.StackTrace, true);
#if DEBUG
                {
                    MessageBox.Show(ex.Message, MethodBase.GetCurrentMethod().ReflectedType.Name.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
#endif
            }
            finally
            {

            }
        }
    }
}
