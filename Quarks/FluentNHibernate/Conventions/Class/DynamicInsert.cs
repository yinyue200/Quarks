﻿using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Quarks.FluentNHibernate.Conventions.Class
{
	class DynamicInsert : IClassConvention
	{
		public void Apply(IClassInstance instance)
		{
			instance.DynamicInsert();
		}
	}
}
