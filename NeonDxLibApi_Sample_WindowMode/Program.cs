using NeonDX.DxLibApi;

namespace NeonDxLibApi_Sample_WindowMode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ウィンドウモード
            NDX_API_Window.ChangeWindowMode(true);

            // Alt+F4やウィンドウの閉じるボタンを無効化
            NDX_API_Window.SetWindowUserCloseEnableFlag(false);

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

                // Alt+F4や閉じるボタンが押されていたら終了
                if (NDX_API_Window.GetWindowUserCloseFlag(true))
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