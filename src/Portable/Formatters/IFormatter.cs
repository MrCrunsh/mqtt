﻿using System.Threading.Tasks;
using Hermes.Messages;

namespace Hermes.Formatters
{
	public interface IFormatter
	{
		bool CanFormat (byte[] packet);

		bool CanFormat (IMessage message);

		/// <exception cref="ProtocolException">ProtocolException</exception>
		Task ReadAsync (byte[] packet);

		/// <exception cref="ProtocolException">ProtocolException</exception>
		Task WriteAsync (IMessage message);
	}
}
