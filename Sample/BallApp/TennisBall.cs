using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class TennisBall : Obj {

        //フィールド
        Random rand = new Random(); //乱数インスタンス
        private static int count;

        public static int Count { get => count; set => count = value; }

        public TennisBall(double xp, double yp) : base(xp, yp, @"pic\tennis_ball.png") {

            int radX = rand.Next(-15, 15);
            MoveX = (radX != 0 ? radX : 1); //乱数で移動量を設定

            int radY = rand.Next(-15, 15);
            MoveY = (radY != 0 ? radY : 1); //乱数で移動量を設定
            Count++;
        }



        //メソッド
        public override void Move() {
            if (PosX >= 700 || PosX < 0)
            {
                MoveX = -MoveX;
            }
            if (PosY >= 500 || PosY < 0)
            {
                MoveY = -MoveY;
            }
            PosX += MoveX;
            PosY += MoveY;
        }

        public override void Move(Keys direction) {
            ;
        }
    }
}
