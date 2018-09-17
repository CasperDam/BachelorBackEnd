﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BachelorBackEnd;
using FrontEndBA.Models.ResearcherModel.AccountViewModels;

namespace FrontEndBA.Utility
{
    public class RegisterConverter
    {
        public static BachelorBackEnd.participants ParticipantobjFromViewToDto(ResearcherRegisterViewModel registerobj)
        {
            BachelorBackEnd.participants currentParticipants = new participants();
            if (registerobj != null)
            {
                currentParticipants.firstname = registerobj.Firstname;
                currentParticipants.email = registerobj.Email;
                currentParticipants.lastname = registerobj.Lastname;
                currentParticipants.password = registerobj.Password;
                currentParticipants.pause = false;

            }

            return currentParticipants;

        }
    }
}
