/*
 * Copyright 2002-2015 Drew Noakes
 *
 *    Modified by Yakov Danilov <yakodani@gmail.com> for Imazen LLC (Ported from Java to C#)
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * More information about this project is available at:
 *
 *    https://drewnoakes.com/code/exif/
 *    https://github.com/drewnoakes/metadata-extractor
 */
using Com.Drew.Metadata;
using JetBrains.Annotations;
using Sharpen;

namespace Com.Drew.Metadata.Exif.Makernotes
{
	/// <summary>
	/// Provides human-readable string representations of tag values stored in a
	/// <see cref="SonyType6MakernoteDirectory"/>
	/// .
	/// </summary>
	/// <author>Drew Noakes https://drewnoakes.com</author>
	public class SonyType6MakernoteDescriptor : TagDescriptor<SonyType6MakernoteDirectory>
	{
		public SonyType6MakernoteDescriptor([NotNull] SonyType6MakernoteDirectory directory)
			: base(directory)
		{
		}

		[CanBeNull]
		public override string GetDescription(int tagType)
		{
			switch (tagType)
			{
				case SonyType6MakernoteDirectory.TagMakernoteThumbVersion:
				{
					return GetMakernoteThumbVersionDescription();
				}

				default:
				{
					return base.GetDescription(tagType);
				}
			}
		}

		[CanBeNull]
		public virtual string GetMakernoteThumbVersionDescription()
		{
			return GetVersionBytesDescription(SonyType6MakernoteDirectory.TagMakernoteThumbVersion, 2);
		}
	}
}
