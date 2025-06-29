﻿using System.Collections.Generic;

namespace AiReview.Core.OpenAI
{
	public class CompletionResponse
	{
		public string Id { get; set; }
		public string Object { get; set; }
		public int Created { get; set; }
		public string Model { get; set; }
		public IEnumerable<Choice> Choices { get; set; }
		public Usage Usage { get; set; }
	}
}