/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

//------------------------------------------------------------------------------
// This code was generated by a tool.
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

// To get up to date fundamental definition files for your hedgefund contact sales@quantconnect.com

using System;
using System.IO;
using Newtonsoft.Json;

namespace QuantConnect.Data.Fundamental
{
	/// <summary>
	/// Definition of the FinancialStatements class
	/// </summary>
	public class FinancialStatements
	{
		/// <summary>
		/// The exact date that is given in the financial statements for each quarter's end.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 20001
		/// </remarks>
		[JsonProperty("20001")]
		public DateTime PeriodEndingDate { get; set; }

		/// <summary>
		/// Specific date on which a company released its filing to the public.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 20002
		/// </remarks>
		[JsonProperty("20002")]
		public DateTime FileDate { get; set; }

		/// <summary>
		/// The accession number is a unique number that EDGAR assigns to each submission as the submission is received.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 20003
		/// </remarks>
		[JsonProperty("20003")]
		public string AccessionNumber { get; set; }

		/// <summary>
		/// The type of filing of the report: for instance, 10-K (annual report) or 10-Q (quarterly report).
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 20004
		/// </remarks>
		[JsonProperty("20004")]
		public string FormType { get; set; }

		/// <summary>
		/// The name of the auditor that performed the financial statement audit for the given period.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 28000
		/// </remarks>
		[JsonProperty("28000")]
		public string PeriodAuditor { get; set; }

		/// <summary>
		/// Auditor opinion code will be one of the following for each annual period:
		/// Code Meaning
		/// UQ Unqualified Opinion
		/// UE Unqualified Opinion with Explanation
		/// QM Qualified - Due to change in accounting method
		/// QL Qualified - Due to litigation
		/// OT Qualified Opinion - Other
		/// AO Adverse Opinion
		/// DS Disclaim an opinion
		/// UA Unaudited
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 28001
		/// </remarks>
		[JsonProperty("28001")]
		public string AuditorReportStatus { get; set; }

		/// <summary>
		/// Which method of inventory valuation was used - LIFO, FIFO, Average, Standard costs, Net realizable value, Others, LIFO and FIFO,
		/// FIFO and Average, FIFO and other, LIFO and Average, LIFO and other, Average and other, 3 or more methods, None
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 28002
		/// </remarks>
		[JsonProperty("28002")]
		public string InventoryValuationMethod { get; set; }

		/// <summary>
		/// The number of shareholders on record
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 28003
		/// </remarks>
		[JsonProperty("28003")]
		public long NumberOfShareHolders { get; set; }

		/// <summary>
		/// The sum of Tier 1 and Tier 2 Capital. Tier 1 capital consists of common shareholders equity, perpetual preferred shareholders equity
		/// with non-cumulative dividends, retained earnings, and minority interests in the equity accounts of consolidated subsidiaries. Tier 2
		/// capital consists of subordinated debt, intermediate-term preferred stock, cumulative and long-term preferred stock, and a portion of
		/// a bank's allowance for loan and lease losses.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 28004
		/// </remarks>
		[JsonProperty("28004")]
		public TotalRiskBasedCapital TotalRiskBasedCapital { get; set; }

		/// <summary>
		/// The instance of the IncomeStatement class
		/// </summary>
		public IncomeStatement IncomeStatement { get; set; }

		/// <summary>
		/// The instance of the BalanceSheet class
		/// </summary>
		public BalanceSheet BalanceSheet { get; set; }

		/// <summary>
		/// The instance of the CashFlowStatement class
		/// </summary>
		public CashFlowStatement CashFlowStatement { get; set; }

		/// <summary>
		/// Creates an instance of the FinancialStatements class
		/// </summary>
		public FinancialStatements()
		{
			TotalRiskBasedCapital = new TotalRiskBasedCapital();
			IncomeStatement = new IncomeStatement();
			BalanceSheet = new BalanceSheet();
			CashFlowStatement = new CashFlowStatement();
		}

		/// <summary>
		/// Sets values for non existing periods from a previous instance
		/// </summary>
		/// <remarks>Used to fill-forward values from previous dates</remarks>
		/// <param name="previous">The previous instance</param>
		public void UpdateValues(FinancialStatements previous)
		{
			if (previous == null) return;

			if (TotalRiskBasedCapital != null) TotalRiskBasedCapital.UpdateValues(previous.TotalRiskBasedCapital);
			if (IncomeStatement != null) IncomeStatement.UpdateValues(previous.IncomeStatement);
			if (BalanceSheet != null) BalanceSheet.UpdateValues(previous.BalanceSheet);
			if (CashFlowStatement != null) CashFlowStatement.UpdateValues(previous.CashFlowStatement);
		}
	}
}
