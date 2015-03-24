using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Stack;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace MyStack2
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region 共有領域
		private CS_Stack Stack;
        #endregion

        #region コンストラクタ
        public MainPage()
        {   // アプリケーション　コンストラクタ
            this.InitializeComponent();

            // 初期表示をクリアする
            ClearResultTextBox();

			// 共有領域を初期化する
//          buffer = new List<int>();
//			strbuf = new List<string>();
			Stack = new CS_Stack();
        }
        #endregion

        #region ［Ｐｕｓｈ（Ｎｕｍｂｅｒ）］ボタン押下
        private void Button01_Click(object sender, RoutedEventArgs e)
        {   // [Push(Num)]ボタン押下
//            WriteLineResult(@"[Push (Number)]");

            int i;

            try
            {
                i = int.Parse(TextBox01.Text);
                Stack.Push(i);

                StackView();
            }
            catch (FormatException)
            {
                ClearResultTextBox();
                WriteLineResult(@"[Push (Number)] : [FormatException]");
            }
        }
        #endregion

        #region ［Ｐｏｐ（Ｎｕｍｂｅｒ）］ボタン押下
        private void Button02_Click(object sender, RoutedEventArgs e)
        {   // [Pop(Num)]ボタン押下
//            WriteLineResult(@"[Pop (Number)]");
            int i;

            try
            {
                i = Stack.Pop();
                WriteLineResult("Pop Result : [{0}]", i);

                StackView();
            }
            catch (ArgumentOutOfRangeException)
            {
                ClearResultTextBox();
                WriteLineResult(@"[Pop (Number)] : [ArgumentOutOfRangeException]");
            }
        }
        #endregion

        #region ［Ｑｕｅ（Ｎｕｍｂｅｒ）］ボタン押下
        private void Button03_Click(object sender, RoutedEventArgs e)
        {   // [Que(Num)]ボタン押下
//            WriteLineResult(@"[Que (Number)]");
            int i,j;

            try
            {
                i = int.Parse(TextBox01.Text);
                j = Stack.Que(i);

                WriteLineResult("Que Result : [{0}]", j);

                StackView();

            }
            catch (ArgumentOutOfRangeException)
            {
                ClearResultTextBox();
                WriteLineResult(@"[Que (Number)] : [ArgumentOutOfRangeException]");
            }
        }
        #endregion

        #region ［Ｃｌｅａｒ（Ｎｕｍｂｅｒ）］ボタン押下
        private void Button04_Click(object sender, RoutedEventArgs e)
        {   // [Clear(Num)]ボタン押下
//            WriteLineResult(@"[Clear (Number)]");
			Stack.Clear();

            StackView();
        }
        #endregion

        #region ［Ｃｈｅｃｋ（Ｎｕｍｂｅｒ）］ボタン押下
        private void Button05_Click(object sender, RoutedEventArgs e)
        {   // [Check(Num)]ボタン押下
//            WriteLineResult(@"[Check (Number)]");
            int i, j;

            try
            {
                i = int.Parse(TextBox01.Text);
                j = Stack.chknum(i);

                WriteLineResult(" Source : [{0}]", i);
                WriteLineResult(" Result : [{0}]", j);

            }
            catch (FormatException)
            {
                ClearResultTextBox();
                WriteLineResult(@"[Check (Number)] : [FormatException]");
            }
        }
        #endregion

        #region ［Ｐｕｓｈ（Ｓｔｒｉｎｇ）］ボタン押下
        private void Button11_Click(object sender, RoutedEventArgs e)
        {   // [Push(Str)]ボタン押下
//            WriteLineResult(@"[Push (String)]");
			Stack.SPush(TextBox01.Text);

            StackSView();

        }
        #endregion

        #region ［Ｐｏｐ（Ｓｔｒｉｎｇ）］ボタン押下
        private void Button12_Click(object sender, RoutedEventArgs e)
        {   // [Pop(Str)]ボタン押下
//            WriteLineResult(@"[Pop (String)]");
            string word;

            try
            {
                word = Stack.SPop();
                WriteLineResult("Pop Result : [{0}]", word);

                StackSView();
            }
            catch (ArgumentOutOfRangeException)
            {
                ClearResultTextBox();
                WriteLineResult(@"[Pop (String)] : [ArgumentOutOfRangeException]");
            }

        }
        #endregion

        #region ［Ｑｕｅ（Ｓｔｒｉｎｇ）］ボタン押下
        private void Button13_Click(object sender, RoutedEventArgs e)
        {   // [Que(Str)]ボタン押下
//            WriteLineResult(@"[Que (String)]");
            string word;

            try
            {
                word = Stack.SQue(TextBox01.Text);

                WriteLineResult("Que Result : [{0}]", word);

                StackSView();
            }
            catch (ArgumentOutOfRangeException)
            {
                ClearResultTextBox();
                WriteLineResult(@"[Que (String)] : [ArgumentOutOfRangeException]");
            }
        }
        #endregion

        #region ［Ｃｌｅａｒ（Ｓｔｒｉｎｇ）］ボタン押下
        private void Button14_Click(object sender, RoutedEventArgs e)
        {   // [Clear(Str)]ボタン押下
//            WriteLineResult(@"[Clear (String)]");
            Stack.sclear();

            StackSView();
        }
        #endregion

        #region ［Ｃｈｅｃｋ（Ｓｔｒｉｎｇ）］ボタン押下
        private void Button15_Click(object sender, RoutedEventArgs e)
        {   // [Check(Str)]ボタン押下
//            WriteLineResult(@"[Check (String)]");
            int i;

			i = Stack.chkstr(TextBox01.Text);

            WriteLineResult(" Source : [{0}]", TextBox01.Text);
            WriteLineResult(" Result : [{0}]", i);
        }
        #endregion

        #region ［Ｒｅｓｅｔ］ボタン押下
        private void Button20_Click(object sender, RoutedEventArgs e)
        {   // [Reset]ボタン押下
            ClearResultTextBox();
        }
        #endregion

        #region Stack View
        private void StackView()
        {
			int _Count;

            ListBox01.Items.Clear();
			_Count = Stack.Count();
            if (_Count != 0)
            {   // 登録情報は有るか？
                for (int j = 0; j < _Count; j++)
                {
                    ListBox01.Items.Add(Stack.View(j));
                }
            }
        }

		private void StackSView()
        {
 			int _Count;

			ListBox01.Items.Clear();
			_Count = Stack.SCount();
            if (_Count != 0)
            {   // 登録情報は有るか？
                for (int j = 0; j < _Count; j++)
                {
                    ListBox01.Items.Add(Stack.SView(j));
                }
            }
		}
        #endregion

    }
}
