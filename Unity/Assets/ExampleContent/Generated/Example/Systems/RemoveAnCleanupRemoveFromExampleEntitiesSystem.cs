//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;
using JCMG.EntitasRedux;

public sealed class RemoveAnCleanupRemoveFromExampleEntitiesSystem : ICleanupSystem
{
	private readonly IGroup<ExampleEntity> _group;
	private readonly List<ExampleEntity> _entities;

	public RemoveAnCleanupRemoveFromExampleEntitiesSystem(IContext<ExampleEntity> context)
	{
		_group = context.GetGroup(ExampleMatcher.AnCleanupRemove);
		_entities = new List<ExampleEntity>();
	}

	/// <summary>
	/// Performs cleanup logic after other systems have executed.
	/// </summary>
	public void Cleanup()
	{
		_group.GetEntities(_entities);
		for (var i = 0; i < _entities.Count; ++i)
		{
			_entities[i].IsAnCleanupRemove = false;
		}
	}
}
