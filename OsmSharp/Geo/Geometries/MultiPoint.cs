﻿// OsmSharp - OpenStreetMap (OSM) SDK
// Copyright (C) 2015 Abelshausen Ben
// 
// This file is part of OsmSharp.
// 
// OsmSharp is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// OsmSharp is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with OsmSharp. If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;

namespace OsmSharp.Geo.Geometries
{
    /// <summary>
    /// A multi point, a collection of zero or more points.
    /// </summary>
    public class MultiPoint : GeometryCollectionBase<Point>
    {
        /// <summary>
        /// Creates a new multipoint.
        /// </summary>
        public MultiPoint()
        {

        }

        /// <summary>
        /// Creates a new multipoint.
        /// </summary>
        public MultiPoint(params Point[] points)
            :base(points)
        {

        }

        /// <summary>
        /// Creates a new multipoint.
        /// </summary>
        public MultiPoint(IEnumerable<Point> points)
            : base(points)
        {

        }
    }
}