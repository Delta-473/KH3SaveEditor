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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xe.Tools.Wpf.Models;

namespace KHSave.SaveEditor.Kh3.Models
{
    public class RecordShotlockListModel<T> :
        GenericListModel<ShotlockRecordItemModel<T>>,
        IEnumerable<ShotlockRecordItemModel<T>>
        where T : struct, IConvertible
    {
        public RecordShotlockListModel(List<short> list1, List<short> list2)
            : base(list1.Select((x, i) => new ShotlockRecordItemModel<T>(list1, list2, i)))
        {
        }

        public RecordShotlockListModel(IEnumerable<ShotlockRecordItemModel<T>> list)
            : base(list)
        {
        }

        public IEnumerator<ShotlockRecordItemModel<T>> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        protected override ShotlockRecordItemModel<T> OnNewItem()
        {
            throw new System.NotImplementedException();
        }
    }
}
