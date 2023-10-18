using NeonDX.DxLibApi;

namespace NeonDxLibApi_Sample_FullScreenMode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DXライブラリの初期化
            NDX_API_System.DxLib_Init();

            while (true)
            {
                // 裏画面をクリア
                NDX_API_Graphics2D.ClearDrawScreen();

                // ESCキーが押されていたら終了
                if (NDX_API_Input.CheckHitKey(NDX_API_Input.KEY_INPUT_ESCAPE))
                {
                    break;
                }

                // 描画処理をここに書きます

                // 裏画面に反映
                NDX_API_Graphics2D.ScreenFlip();
            }

            // DXライブラリの終了
            NDX_API_System.DxLib_End();
        }
    }
}