using Gamebook.Model;
using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Services
{
    public class GameLogic
    {
        RoomRepository _rr = new RoomRepository();
        public bool Start(SessionStorage<GameState> _ss)
        {
            GameState empty = new GameState();
            empty.Start = 0;
            empty.CrowbarYN = 0;
            empty.KitchenHall2 = 0;
            empty.KnifeYN = 0;
            empty.BedroomHall3 = 0;
            empty.LivingRoomBasementWindow = 0;
            empty.KeepCrowbarYN = 0;
            empty.RunFight = 0;
            empty.PushPull = 0;
            empty.CrowbarInv = false;
            empty.KnifeInv = false;
            empty.FlashlightInv = false;
            _ss.Save("_Game", empty);
            return true;
        }
        public void Game(SessionStorage<GameState> _ss,SessionStorage<int> _cr, int Choice)
        {
            if(_ss.LoadOrCreate("_Game").PushPull == 1)
            {
                //pull
                _cr.Save("_CurrentRoom", 34);
            }
            else if (_ss.LoadOrCreate("_Game").PushPull == 2)
            {
                //push
                _cr.Save("_CurrentRoom", 33);
            }
            else
            {
                if (_ss.LoadOrCreate("_Game").RunFight == 1)
                {
                    //run
                    if(_ss.LoadOrCreate("_Game").CrowbarInv == true)
                    {
                        //has crowbar
                        _cr.Save("_CurrentRoom", 27);
                    }
                    else
                    {
                        //doesn't have crowbar
                        _cr.Save("_CurrentRoom", 28);
                    }
                }
                else if (_ss.LoadOrCreate("_Game").RunFight == 2)
                {
                    //fight
                    if (_ss.LoadOrCreate("_Game").KnifeInv == true)
                    {
                        //has knife
                        _cr.Save("_CurrentRoom", 29);
                    }
                    else
                    {
                        //doesn't have knife
                        _cr.Save("_CurrentRoom", 30);
                    }
                }
                else
                {
                    //going to basement
                    if (_ss.LoadOrCreate("_Game").FlashlightInv == false)
                    {
                        //doesn't have flashlight
                        _cr.Save("_CurrentRoom", 22);
                    }
                    else
                    {
                        //has flashlight
                        if (_ss.LoadOrCreate("_Game").)
                    }
                }
            }
        }
    }
}
