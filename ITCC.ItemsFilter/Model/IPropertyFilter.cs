﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
// ****************************************************************************
// <author>mishkin Ivan</author>
// <email>Mishkin_Ivan@mail.ru</email>
// <date>28.01.2015</date>
// <project>ItemsFilter</project>
// <license> GNU General Public License version 3 (GPLv3) </license>
// ****************************************************************************

using System.ComponentModel;

namespace ITCC.ItemsFilter.Model
{
    /// <summary>
    ///     Defines the contract for Property filter.
    /// </summary>
    public interface IPropertyFilter : IFilter
    {
        /// <summary>
        ///     Gets the property info that use to get property value from item.
        /// </summary>
        /// <value>The property info.</value>
        ItemPropertyInfo PropertyInfo { get; }
    }
}