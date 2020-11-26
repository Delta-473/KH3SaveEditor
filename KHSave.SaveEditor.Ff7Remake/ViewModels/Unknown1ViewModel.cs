/*
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

using KHSave.Attributes;
using KHSave.LibFf7Remake;
using KHSave.LibFf7Remake.Models;
using KHSave.LibFf7Remake.Types;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Xe.Tools;

namespace KHSave.SaveEditor.Ff7Remake.ViewModels
{
    public class Unknown1ViewModel : BaseNotifyPropertyChanged
    {
        private readonly SaveFf7Remake _save;
        private int _selectedIndex;

        public Unknown1ViewModel(SaveFf7Remake save)
        {
            _save = save;
        }

        public IEnumerable<string> Items => _save.ChunkCommon.CharactersUnknown
            .Select((_, i) => InfoAttribute.GetInfo((CharacterType)i));
        public bool IsItemSelected => SelectedIndex >= 0;
        public Visibility EntryVisible => IsItemSelected ? Visibility.Visible : Visibility.Collapsed;
        public Visibility EntryNotVisible => !IsItemSelected ? Visibility.Visible : Visibility.Collapsed;

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                _selectedIndex = value;
                OnPropertyChanged(nameof(IsItemSelected));
                OnPropertyChanged(nameof(Unknown00));
                OnPropertyChanged(nameof(Unknown01));
                OnPropertyChanged(nameof(Unknown02));
                OnPropertyChanged(nameof(Unknown03));
                OnPropertyChanged(nameof(Unknown04));
                OnPropertyChanged(nameof(Unknown08));
                OnPropertyChanged(nameof(KillCount));
            }
        }

        public UnknownStructure SelectedValue => _save.ChunkCommon.CharactersUnknown[_selectedIndex];

        public byte Unknown00 { get => SelectedValue.Unknown00; set => SelectedValue.Unknown00 = value; }
        public byte Unknown01 { get => SelectedValue.Unknown01; set => SelectedValue.Unknown01 = value; }
        public byte Unknown02 { get => SelectedValue.Unknown02; set => SelectedValue.Unknown02 = value; }
        public byte Unknown03 { get => SelectedValue.Unknown03; set => SelectedValue.Unknown03 = value; }
        public int Unknown04 { get => SelectedValue.Unknown04; set => SelectedValue.Unknown04 = value; }
        public int Unknown08 { get => SelectedValue.Unknown08; set => SelectedValue.Unknown08 = value; }
        public int KillCount { get => SelectedValue.KillCount; set => SelectedValue.KillCount = value; }
    }
}
