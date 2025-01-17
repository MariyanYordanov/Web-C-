﻿using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
        //This code holds the shares app data in a static field in the controller class.
        //This is just for the example, and it is generally a bad practice! 

        private static readonly List<KeyValuePair<string, string>> messages = new();

        [HttpGet]
        public IActionResult Show()
        {
<<<<<<< HEAD
            if (messages.Count < 1)
=======
            if (messages.Count() < 1)
>>>>>>> d00ec907c42233f848da40673a836768061d8226
            {
                return View(new ChatViewModel());
            }

            var chatModel = new ChatViewModel()
            {
                Messages = messages.Select(m => new MessageViewModel()
                {
                    Sender = m.Key,
                    MessageText = m.Value
                })
                .ToList()
            };

            return View(chatModel);
        }

        [HttpPost]
        public IActionResult Send(ChatViewModel chat)
        {
            var newMessage = chat.CurrentMessage;

            messages.Add(new KeyValuePair<string, string>(newMessage.Sender,newMessage.MessageText));

            return RedirectToAction("Show");
        }
    }
}
