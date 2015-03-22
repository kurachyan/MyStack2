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

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace MyStack2
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region コンストラクタ
        public MainPage()
        {   // アプリケーション　コンストラクタ
            this.InitializeComponent();

            // 初期表示をクリアする
            ClearResultTextBox();
//			TextBox02.Text = "";
        }
        #endregion

        #region ［Ｐｕｓｈ（Ｎｕｍｂｅｒ）］ボタン押下
        private void Button01_Click(object sender, RoutedEventArgs e)
        {   // [Push(Num)]ボタン押下
            WriteLineResult(@"[Push (Number)]");

        }
        #endregion

        #region ［Ｐｏｐ（Ｎｕｍｂｅｒ）］ボタン押下
        private void Button02_Click(object sender, RoutedEventArgs e)
        {   // [Pop(Num)]ボタン押下
            WriteLineResult(@"[Pop (Number)]");

        }
        #endregion

        #region ［Ｑｕｅ（Ｎｕｍｂｅｒ）］ボタン押下
        private void Button03_Click(object sender, RoutedEventArgs e)
        {   // [Que(Num)]ボタン押下
            WriteLineResult(@"[Que (Number)]");

        }
        #endregion

        #region ［Ｃｌｅａｒ（Ｎｕｍｂｅｒ）］ボタン押下
        private void Button04_Click(object sender, RoutedEventArgs e)
        {   // [Clear(Num)]ボタン押下
            WriteLineResult(@"[Clear (Number)]");

        }
        #endregion

        #region ［Ｃｈｅｃｋ（Ｎｕｍｂｅｒ）］ボタン押下
        private void Button05_Click(object sender, RoutedEventArgs e)
        {   // [Check(Num)]ボタン押下
            WriteLineResult(@"[Check (Number)]");

        }
        #endregion

        #region ［Ｐｕｓｈ（Ｓｔｒｉｎｇ）］ボタン押下
        private void Button11_Click(object sender, RoutedEventArgs e)
        {   // [Push(Str)]ボタン押下
            WriteLineResult(@"[Push (String)]");

        }
        #endregion

        #region ［Ｐｏｐ（Ｓｔｒｉｎｇ）］ボタン押下
        private void Button12_Click(object sender, RoutedEventArgs e)
        {   // [Pop(Str)]ボタン押下
            WriteLineResult(@"[Pop (String)]");

        }
        #endregion

        #region ［Ｑｕｅ（Ｓｔｒｉｎｇ）］ボタン押下
        private void Button13_Click(object sender, RoutedEventArgs e)
        {   // [Que(Str)]ボタン押下
            WriteLineResult(@"[Que (String)]");

        }
        #endregion

        #region ［Ｃｌｅａｒ（Ｓｔｒｉｎｇ）］ボタン押下
        private void Button14_Click(object sender, RoutedEventArgs e)
        {   // [Clear(Str)]ボタン押下
            WriteLineResult(@"[Clear (String)]");

        }
        #endregion

        #region ［Ｃｈｅｃｋ（Ｓｔｒｉｎｇ）］ボタン押下
        private void Button15_Click(object sender, RoutedEventArgs e)
        {   // [Check(Str)]ボタン押下
            WriteLineResult(@"[Check (String)]");

        }
        #endregion

        #region ［Ｒｅｓｅｔ］ボタン押下
        private void Button20_Click(object sender, RoutedEventArgs e)
        {   // [Reset]ボタン押下
            ClearResultTextBox();

//            TextBox02.Text = "";

        }
        #endregion


    }
}
