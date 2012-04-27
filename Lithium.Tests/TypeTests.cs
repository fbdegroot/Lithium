﻿using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using Lithium.Extensions;
using Lithium.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lithium.Tests
{
	[TestClass]
	public class TypeTests
	{
		protected static IDbConnection Connection { get; private set; }

		[ClassInitialize]
		public static void SetUp(TestContext context)
		{
			Connection = new SqlCeConnection(@"Data Source=Database\Tests.sdf");
			// Connection = new SqlConnection(@"");

			Connection.Open();
		}

		[ClassCleanup]
		public static void TearDown()
		{
			Connection.Dispose();
		}

		[TestMethod]
		public void Byte()
		{
			byte a = 1;
			byte? b = 2;
			byte? c = null;

			var resultA = Connection.Query<byte>(@"select @a", new { a }).Single();
			Assert.AreEqual(a, resultA);

			var resultB = Connection.Query<byte?>(@"select @b", new { b }).Single();
			Assert.AreEqual(b, resultB);

			var resultC = Connection.Query<byte?>(@"select @c", new { c }).Single();
			Assert.AreEqual(c, resultC);

			var resultD = Connection.Query<dynamic>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, resultD.a);
			Assert.AreEqual(b, resultD.b);
			Assert.AreEqual(c, resultD.c);

			var result = Connection.Query<ByteTest>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, result.a);
			Assert.AreEqual(b, result.b);
			Assert.AreEqual(c, result.c);
		}

		[TestMethod]
		public void Short()
		{
			short a = 1;
			short? b = 2;
			short? c = null;

			var resultA = Connection.Query<short>(@"select @a", new { a }).Single();
			Assert.AreEqual(a, resultA);

			var resultB = Connection.Query<short?>(@"select @b", new { b }).Single();
			Assert.AreEqual(b, resultB);

			var resultC = Connection.Query<short?>(@"select @c", new { c }).Single();
			Assert.AreEqual(c, resultC);

			var resultD = Connection.Query<dynamic>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, resultD.a);
			Assert.AreEqual(b, resultD.b);
			Assert.AreEqual(c, resultD.c);

			var result = Connection.Query<ShortTest>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, result.a);
			Assert.AreEqual(b, result.b);
			Assert.AreEqual(c, result.c);
		}

		[TestMethod]
		public void Int()
		{
			int a = 1;
			int? b = 2;
			int? c = null;

			var resultA = Connection.Query<int>(@"select @a", new { a }).Single();
			Assert.AreEqual(a, resultA);

			var resultB = Connection.Query<int?>(@"select @b", new { b }).Single();
			Assert.AreEqual(b, resultB);

			var resultC = Connection.Query<int?>(@"select @c", new { c }).Single();
			Assert.AreEqual(c, resultC);

			var resultD = Connection.Query<dynamic>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, resultD.a);
			Assert.AreEqual(b, resultD.b);
			Assert.AreEqual(c, resultD.c);

			var result = Connection.Query<IntTest>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, result.a);
			Assert.AreEqual(b, result.b);
			Assert.AreEqual(c, result.c);
		}

		[TestMethod]
		public void Long()
		{
			long a = 1;
			long? b = 2;
			long? c = null;

			var resultA = Connection.Query<long>(@"select @a", new { a }).Single();
			Assert.AreEqual(a, resultA);

			var resultB = Connection.Query<long?>(@"select @b", new { b }).Single();
			Assert.AreEqual(b, resultB);

			var resultC = Connection.Query<long?>(@"select @c", new { c }).Single();
			Assert.AreEqual(c, resultC);

			var resultD = Connection.Query<dynamic>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, resultD.a);
			Assert.AreEqual(b, resultD.b);
			Assert.AreEqual(c, resultD.c);

			var result = Connection.Query<LongTest>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, result.a);
			Assert.AreEqual(b, result.b);
			Assert.AreEqual(c, result.c);
		}

		[TestMethod]
		public void Float()
		{
			float a = 0.1f;
			float? b = 0.2f;
			float? c = null;

			var resultA = Connection.Query<float>(@"select @a", new { a }).Single();
			Assert.AreEqual(a, resultA);

			var resultB = Connection.Query<float?>(@"select @b", new { b }).Single();
			Assert.AreEqual(b, resultB);

			var resultC = Connection.Query<float?>(@"select @c", new { c }).Single();
			Assert.AreEqual(c, resultC);

			var resultD = Connection.Query<dynamic>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, resultD.a);
			Assert.AreEqual(b, resultD.b);
			Assert.AreEqual(c, resultD.c);

			var result = Connection.Query<FloatTest>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, result.a);
			Assert.AreEqual(b, result.b);
			Assert.AreEqual(c, result.c);
		}

		[TestMethod]
		public void Double()
		{
			double a = 0.1d;
			double? b = 0.2d;
			double? c = null;

			var resultA = Connection.Query<double>(@"select @a", new { a }).Single();
			Assert.AreEqual(a, resultA);

			var resultB = Connection.Query<double?>(@"select @b", new { b }).Single();
			Assert.AreEqual(b, resultB);

			var resultC = Connection.Query<double?>(@"select @c", new { c }).Single();
			Assert.AreEqual(c, resultC);

			var resultD = Connection.Query<dynamic>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, resultD.a);
			Assert.AreEqual(b, resultD.b);
			Assert.AreEqual(c, resultD.c);

			var result = Connection.Query<DoubleTest>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, result.a);
			Assert.AreEqual(b, result.b);
			Assert.AreEqual(c, result.c);
		}

		[TestMethod]
		public void Decimal()
		{
			decimal a = 0.1m;
			decimal? b = 0.2m;
			decimal? c = null;

			var resultA = Connection.Query<decimal>(@"select @a", new { a }).Single();
			Assert.AreEqual(a, resultA);

			var resultB = Connection.Query<decimal?>(@"select @b", new { b }).Single();
			Assert.AreEqual(b, resultB);

			var resultC = Connection.Query<decimal?>(@"select @c", new { c }).Single();
			Assert.AreEqual(c, resultC);

			var resultD = Connection.Query<dynamic>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, resultD.a);
			Assert.AreEqual(b, resultD.b);
			Assert.AreEqual(c, resultD.c);

			var result = Connection.Query<DecimalTest>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, result.a);
			Assert.AreEqual(b, result.b);
			Assert.AreEqual(c, result.c);
		}

		[TestMethod]
		public void Bool()
		{
			bool a = true;
			bool? b = false;
			bool? c = null;

			var resultA = Connection.Query<bool>(@"select @a", new { a }).Single();
			Assert.AreEqual(a, resultA);

			var resultB = Connection.Query<bool?>(@"select @b", new { b }).Single();
			Assert.AreEqual(b, resultB);

			var resultC = Connection.Query<bool?>(@"select @c", new { c }).Single();
			Assert.AreEqual(c, resultC);

			var resultD = Connection.Query<dynamic>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, resultD.a);
			Assert.AreEqual(b, resultD.b);
			Assert.AreEqual(c, resultD.c);

			var result = Connection.Query<BoolTest>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, result.a);
			Assert.AreEqual(b, result.b);
			Assert.AreEqual(c, result.c);
		}

		[TestMethod]
		public void Char()
		{
			char a = 'a';
			char? b = 'b';
			char? c = null;

			var resultA = Connection.Query<char>(@"select @a", new { a }).Single();
			Assert.AreEqual(a, resultA);

			var resultB = Connection.Query<char?>(@"select @b", new { b }).Single();
			Assert.AreEqual(b, resultB);

			var resultC = Connection.Query<char?>(@"select @c", new { c }).Single();
			Assert.AreEqual(c, resultC);

			// chars worden niet ondersteund dus een char komt altijd terug als een string als het return type dynamic is
			var resultD = Connection.Query<dynamic>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual("a", resultD.a);
			Assert.AreEqual("b", resultD.b);
			Assert.AreEqual(null, resultD.c);

			var result = Connection.Query<CharTest>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, result.a);
			Assert.AreEqual(b, result.b);
			Assert.AreEqual(c, result.c);
		}

		[TestMethod]
		public void String()
		{
			string a = "string";
			string b = null;

			var resultA = Connection.Query<string>(@"select @a", new { a }).Single();
			Assert.AreEqual(a, resultA);

			var resultB = Connection.Query<string>(@"select @b", new { b }).Single();
			Assert.AreEqual(b, resultB);

			var resultC = Connection.Query<StringTest>(@"select @a a, @b b", new { a, b }).Single();
			Assert.AreEqual(a, resultC.a);
			Assert.AreEqual(b, resultC.b);

			var resultD = Connection.Query<dynamic>(@"select @a a, @b b", new { a, b }).Single();
			Assert.AreEqual(a, resultD.a);
			Assert.AreEqual(b, resultD.b);

			var dynamicResult = Connection.Query(@"select @a a, @b b", new { a, b }).Single();
			Assert.AreEqual(a, dynamicResult.a);
			Assert.AreEqual(b, dynamicResult.b);
		}

		[TestMethod]
		public void Guid()
		{
			Guid a = System.Guid.NewGuid();
			Guid? b = System.Guid.NewGuid();
			Guid? c = null;

			var resultA = Connection.Query<Guid>(@"select @a", new { a }).Single();
			Assert.AreEqual(a, resultA);

			var resultB = Connection.Query<Guid?>(@"select @b", new { b }).Single();
			Assert.AreEqual(b, resultB);

			var resultC = Connection.Query<Guid?>(@"select @c", new { c }).Single();
			Assert.AreEqual(c, resultC);

			var resultD = Connection.Query<dynamic>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, resultD.a);
			Assert.AreEqual(b, resultD.b);
			Assert.AreEqual(c, resultD.c);

			var result = Connection.Query<GuidTest>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, result.a);
			Assert.AreEqual(b, result.b);
			Assert.AreEqual(c, result.c);
		}

		[TestMethod]
		public void DateTime()
		{
			DateTime a = System.DateTime.Now;
			DateTime? b = System.DateTime.Now;
			DateTime? c = null;

			var resultA = Connection.Query<DateTime>(@"select @a", new { a }).Single();
			var differenceA = (a - resultA).Milliseconds;
			Assert.IsTrue(differenceA > -100 && differenceA < 100);

			var resultB = Connection.Query<DateTime?>(@"select @b", new { b }).Single();
			var differenceB = (a - resultB).Value.Milliseconds;
			Assert.IsTrue(differenceB > -100 && differenceB < 100);

			var resultC = Connection.Query<DateTime?>(@"select @c", new { c }).Single();
			Assert.AreEqual(c, resultC);

			var resultD = Connection.Query<dynamic>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			differenceA = (a - resultD.a).Milliseconds;
			differenceB = (b - resultD.b).Milliseconds;
			Assert.IsTrue(differenceA > -100 && differenceA < 100);
			Assert.IsTrue(differenceB > -100 && differenceB < 100);
			Assert.AreEqual(c, resultD.c);

			var result = Connection.Query<DateTimeTest>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			differenceA = (a - result.a).Milliseconds;
			differenceB = (b - result.b).Value.Milliseconds;
			Assert.IsTrue(differenceA > -100 && differenceA < 100);
			Assert.IsTrue(differenceB > -100 && differenceB < 100);
			Assert.AreEqual(c, result.c);
		}

		[TestMethod]
		public void DateTimeOffset()
		{
			// SQLCE doesn't support DateTimeOffset
			if (Connection.GetConnectionType() == ConnectionType.SqlCe)
				return;

			DateTimeOffset a = System.DateTime.Now;
			DateTimeOffset? b = System.DateTime.Now;
			DateTimeOffset? c = null;

			var resultA = Connection.Query<DateTimeOffset>(@"select @a", new { a }).Single();
			Assert.AreEqual(a, resultA);

			var resultB = Connection.Query<DateTimeOffset?>(@"select @b", new { b }).Single();
			Assert.AreEqual(b, resultB);

			var resultC = Connection.Query<DateTimeOffset?>(@"select @c", new { c }).Single();
			Assert.AreEqual(c, resultC);

			var resultD = Connection.Query<dynamic>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, resultD.a);
			Assert.AreEqual(b, resultD.b);
			Assert.AreEqual(c, resultD.c);

			var result = Connection.Query<DateTimeOffsetTest>(@"select @a a, @b b, @c c", new { a, b, c }).Single();
			Assert.AreEqual(a, result.a);
			Assert.AreEqual(b, result.b);
			Assert.AreEqual(c, result.c);
		}

		[TestMethod]
		public void Enums()
		{
			var resultA = Connection.Query<SomeEnum>(@"select @a", new { a = SomeEnum.Two }).Single();
			Assert.AreEqual(SomeEnum.Two, resultA);

			var resultB = Connection.Query<SomeEnum>(@"select @a", new { a = (int)SomeEnum.Two }).Single();
			Assert.AreEqual(SomeEnum.Two, resultB);

			var resultC = Connection.Query<EnumTest>(@"select @a SomeEnum", new { a = SomeEnum.Two }).Single();
			Assert.AreEqual(SomeEnum.Two, resultC.SomeEnum);
		}
	}
}