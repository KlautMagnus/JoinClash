using UnityEngine;

namespace Animations.Stickmen
{
	[RequireComponent(typeof(Animator))]
	public class StickmanAnimations : MonoBehaviour
	{
		private Animator _animator;
		private static readonly int IsRuning = Animator.StringToHash("IsRuning");

		private void Start()
		{
			_animator = GetComponent<Animator>();
		
		}
		
		[ContextMenu(nameof(EnterRunState))]
		public void EnterRunState()
		{
			_animator.SetBool(IsRuning, true);
		}
	}
}