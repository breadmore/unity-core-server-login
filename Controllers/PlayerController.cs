using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotnetCoreServer.Models;

namespace DotnetCoreServer.Controllers
{
    [Route("[controller]/[action]")]
    public class PlayerController : Controller
    {
        IPlayerDao playerDao;

        public PlayerController(IPlayerDao playerDao)
        {
            this.playerDao = playerDao;
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public Player Get(int id)
        {
            Player player = playerDao.GetPlayer(id);
            return player;
        }

        [HttpGet]
        public PlayerResult Info(int PlayerID){

            PlayerResult result = new PlayerResult();
            result.Data = playerDao.GetPlayer(PlayerID);
            return result;

        }

        //[HttpPost]
        //public UserResult Update([FromBody] User requestUser){

        //    UserResult result = new UserResult();
        //    userDao.UpdateUser(requestUser);
            
        //    result.Data = userDao.GetUser(requestUser.UserID);

        //    result.ResultCode = 1;
        //    result.Message = "Success";

        //    return result;
        //}

    }

}