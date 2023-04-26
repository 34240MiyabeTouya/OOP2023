using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class SoccerBall : Obj {

        //フィールド
        Random rand = new Random(); //乱数インスタンス
        private static int count;

        public static int Count { get => count; set => count = value; }

        //コンストラクタ
        public SoccerBall(double xp, double yp) : base(xp, yp, @"pic\soccer_ball.png") {

            int radX = rand.Next(-15, 15);
            MoveX = (radX != 0 ? radX : 1); //乱数で移動量を設定

            int radY = rand.Next(-15, 15);
            MoveY = (radY != 0 ? radY : 1); //乱数で移動量を設定
            Count++;
        }

        //メソッド
        public override void Move(PictureBox pbBar, PictureBox pbBall) {
            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y, pbBar.Width, pbBar.Height);
            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);


            if (PosY >= 520 || PosY < 0 || rBar.IntersectsWith(rBall))
            {
                MoveY = -MoveY;
            }
            if (PosX >= 730 || PosX < 0)
            {
                MoveX = -MoveX;
            }
            PosX += MoveX;
            PosY += MoveY;
        }

        public override void Move(Keys direction) {
            ;
        }
    }
}
