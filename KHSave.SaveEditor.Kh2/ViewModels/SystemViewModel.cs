﻿/*
    Kingdom Save Editor
    Copyright (C) 2020 Luciano Ciccariello

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using KHSave.Lib2;
using KHSave.Lib2.Types;
using KHSave.SaveEditor.Common.Models;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Xe.Tools;

namespace KHSave.SaveEditor.Kh2.ViewModels
{
    public class SystemViewModel : BaseNotifyPropertyChanged
    {
        private readonly ISaveKh2 save;

        public SystemViewModel(ISaveKh2 save)
        {
            this.save = save;
            ShortcutItems = new KhEnumListModel<EnumIconTypeModel<CommandType>, CommandType>(() => default(CommandType), x => { });
            Difficulty = new KhEnumListModel<Difficulty>(() => save.Difficulty, x => save.Difficulty = x);
            Worlds = new KhEnumListModel<WorldType>();
        }

        public KhEnumListModel<EnumIconTypeModel<CommandType>, CommandType> ShortcutItems { get; }
        public KhEnumListModel<Difficulty> Difficulty { get; }
        public KhEnumListModel<WorldType> Worlds { get; }
        public IEnumerable<RoomViewModel> Rooms => Data.Rooms.Where(x => x.World == WorldId).Select(x => new RoomViewModel(x));

        public int Timer { get => save.Timer; set => save.Timer = value; }
        public int Munny { get => save.MunnyAmount; set => save.MunnyAmount = value; }
        public int Experience { get => save.Experience; set => save.Experience = value; }
        public int BonusLevel { get => save.BonusLevel; set => save.BonusLevel = value; }

        public WorldType WorldId
        {
            get => save.WorldId;
            set
            {
                save.WorldId = value;
                OnPropertyChanged(nameof(Rooms));
            }
        }
        public byte RoomId { get => save.RoomId; set => save.RoomId = value; }
        public byte SpawnId { get => save.SpawnId; set => save.SpawnId = value; }

        public CommandType ShortcutCircle { get => save.ShortcutCircle; set => save.ShortcutCircle = value; }
        public CommandType ShortcutTriangle { get => save.ShortcutTriangle; set => save.ShortcutTriangle = value; }
        public CommandType ShortcutSquare { get => save.ShortcutSquare; set => save.ShortcutSquare = value; }
        public CommandType ShortcutCross { get => save.ShortcutCross; set => save.ShortcutCross = value; }
    }
}
