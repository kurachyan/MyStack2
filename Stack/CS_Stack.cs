using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LRSkip;

namespace Stack
{
    public class CS_Stack
    {
        #region 共有領域
        private List<int> buffer;		// 数値用
		private List<string> strbuf;	// 文字列用
		private CS_Lskip lskip;     // 文字列整形
        private CS_Rskip rskip;
        #endregion

        #region コンストラクタ
        public CS_Stack()
        {   // コンストラクタ
			// 共有領域を初期化する
			buffer = new List<int>();
			strbuf = new List<string>();

			// 文字列整形を用意する
            rskip = new CS_Rskip();
            lskip = new CS_Lskip();
		}
        #endregion

        #region モジュール
        public void Push(int Data)
        {   // 数値情報をスタックに格納
            buffer.Insert(0, Data);            // 要素設定
        }

        public int Pop()
        {   // 数値情報をスタックから取り出し
            int ret;

            ret = buffer[0];              // 要素取り出し
            buffer.RemoveAt(0);         // 要素情報削除

            return (ret);
        }

        public int Que(int Data)
        {   // 数値情報をＦＩＦＯで取り出し
            int ret;
            int i;

            i = buffer.Count;           // 下限要素の取り出し
            ret = buffer[i - 1];
            buffer.RemoveAt(i - 1);     // 下限要素の削除

            buffer.Insert(0, Data);            // 上限の要素設定

            return (ret);
        }

        public int View(int vpos)
        {	// 指定位置の数値情報を取り出し
            return (buffer[vpos]);
        }

		public int Count()
		{	// 数値情報スタックから、件数取り出し
			return (buffer.Count());
		}

        public void dclear()
        {   // 数値情報管理を初期化する
			buffer.Clear();
        }

        public int chknum(int Data)
        {   // 登録確認
            return (buffer.IndexOf(Data));
        }

        public void SPush(String Sdata)
        {   // 文字列情報をスタックに格納
            String wbuf;

            rskip.Wbuf = Sdata;             // 不要情報を削除
            rskip.Exec();
            lskip.Wbuf = rskip.Wbuf;
            lskip.Exec();
            wbuf = lskip.Wbuf;

            strbuf.Insert(0, wbuf);            // 要素設定
        }

        public String SPop()
        {   // 文字列情報をスタックから取り出し
            String wbuf;

            wbuf = strbuf[0];              // 要素取り出し
            strbuf.RemoveAt(0);         // 要素情報削除

            return (wbuf);
        }

        public String SQue(String Sdata)
        {   // 文字列情報をＦＩＦＯで取り出し
            String wbuf;
			String ret;
			int i;

            rskip.Wbuf = Sdata;             // 不要情報を削除
            rskip.Exec();
            lskip.Wbuf = rskip.Wbuf;
            lskip.Exec();
            wbuf = lskip.Wbuf;

            i = strbuf.Count;           // 下限要素の取り出し
            ret = strbuf[i - 1];
            strbuf.RemoveAt(i - 1);     // 下限要素の削除

            strbuf.Insert(0, wbuf);            // 上限の要素設定

            return (ret);
        }

        public String SView(int vpos)
        {
             return (strbuf[vpos]);
        }

		public int SCount()
		{	// 数値情報スタックから、件数取り出し
			return (strbuf.Count());
		}

        public void sclear()
        {   // 文字列情報管理を初期化する
			strbuf.Clear();
        }

        public int chkstr(String Sdata)
        {   // 登録確認
            String wbuf;

            rskip.Wbuf = Sdata;             // 不要情報を削除
            rskip.Exec();
            lskip.Wbuf = rskip.Wbuf;
            lskip.Exec();
            wbuf = lskip.Wbuf;

            return (strbuf.IndexOf(wbuf));
		}

        public void Clear()
        {   // 作業領域の初期化
			dclear();
			sclear();
        }
        public void Exec()
        {   // 構文評価を行う
        }
        #endregion

        #region サブ・モジュール
        #endregion

    }
}
