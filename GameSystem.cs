using System;

namespace libRPG
{
    public static class GameSystem
    {
        private static Action ExitCallback;

        public static void SetExitCallback(Action func){
            ExitCallback = func;
        }
        public static void Exit(){
            ExitCallback();
        }
    }
}
