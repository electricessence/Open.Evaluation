﻿using Open.Hierarchy;
using System;
using System.Collections.Generic;

namespace Open.Evaluation
{
	public interface ICatalog<T>
		where T : IEvaluate
    {
		TItem Register<TItem>(TItem item)
			where TItem : T;

		TItem Register<TItem>(string id, Func<string, TItem> factory)
			where TItem : T;

		bool TryGetItem<TItem>(string id, out TItem item)
			where TItem : T;

		T GetReduced(T source);

		bool TryGetReduced(T source, out T reduction);

		IEnumerable<T> Flatten<TFlat>(IEnumerable<T> source)
			where TFlat : IParent<T>;
	}
}
