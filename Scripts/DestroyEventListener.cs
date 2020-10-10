using System;
using UnityEngine;

namespace Kogane
{
	/// <summary>
	/// ゲームオブジェクトが破棄された時にイベントを実行するコンポーネント
	/// </summary>
	[DisallowMultipleComponent]
	public sealed class DestroyEventListener : MonoBehaviour
	{
		//================================================================================
		// イベント
		//================================================================================
		/// <summary>
		/// ゲームオブジェクトが破棄された時に呼び出されます
		/// </summary>
		public Action OnDestroyed { get; set; }
		
		//================================================================================
		// 関数
		//================================================================================
		/// <summary>
		/// ゲームオブジェクトが破棄された時に呼び出されるコールバック
		/// </summary>
		private void OnDestroy()
		{
			OnDestroyed?.Invoke();
		}
	}
}