﻿using Model.StateMachine;
using Model.Stickmen;

namespace Model.Sources.Model.StateMachine.States.Movement
{
	public abstract class EntityMoveStatesGroup : EntityState
	{
		private const float AccelerationToRun = 1.0f;
		private readonly StickmanMovement _movement;

		public EntityMoveStatesGroup(StickmanMovement movement, int animationHash) : base(animationHash)
		{
			_movement = movement;
		}

		protected bool IsRunning => _movement.Acceleration >= AccelerationToRun;
	}
}