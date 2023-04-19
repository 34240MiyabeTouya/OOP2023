using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        //フィールド
        private Image image; //画像データ

        private double posX; //x座標
        private double posY; //y座標

        private double moveX;  //移動量（x方向）
        private double moveY;  //移動量（y方向）

        Random rand = new Random();　//乱数インスタンス

        //コンストラクタ
        public SoccerBall(double xp,double yp) {
            Image = Image.FromFile(@"pic\soccer_ball.png");
            posX = xp;
            posY = yp;

            int radX = rand.Next(-15, 15);
            moveX = (radX != 0 ? radX : 1); //乱数で移動量を設定

            int radY = rand.Next(-15, 15);
            moveY = (radY != 0 ? radY : 1); //乱数で移動量を設定

        }
        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        //メソッド
        public void Move() {

            if (posX >= 700 || PosX < 0)
            {
                moveX = -moveX;
            }
            if (posY >= 500 || PosY < 0)
            {
                moveY = -moveY;
            }
            PosX += moveX;
            PosY += moveY;
        }
    }
}
