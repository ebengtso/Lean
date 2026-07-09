# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_026/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_026/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 105
- Entry signals: 105
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8381
- Total paired trade PnL: 6992.10
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 20.7 minutes

## Lean Runtime Statistics
- Equity: $106,992.10
- Net Profit: $6,992.10
- Return: 6.99 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $45,592,039.10

## Risk And Efficiency
- Exposure hours: 36.2
- PnL per exposure hour: 193.35
- Calendar span days: 12.3
- PnL per calendar day: 567.65
- Trades per calendar day: 8.52
- Exposure share of calendar time: 12.2%
- Growth quality score: 10998.3
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 63
- Fast PnL per exposure hour: 747.67

## Pullback Broken Structure Veto
- Blocked signal rows: 1226
- Blocked by profile: `{"charm_pin_pullback_long": 1174, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 32, "charm_wall_breakaway_long": 5, "pullback_long": 31, "pullback_long_no_0dte": 3, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1304.999999999991, "breakout_long_no_0dte": 278.40000000001237, "call_wall_acceptance_long": 91.0, "charm_pin_pullback_long": 1111.1000000000959, "charm_wall_breakaway_long": 985.5999999999876, "pullback_long": 2408.2000000001935, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 721.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=31.3269, sortinoRatio=0, alpha=0, beta=0, informationRatio=31.9207, drawdown=0.004
- Trades: sharpeRatio=1.0006, averageMAE=-102.0224, averageMFE=85.2838, largestMAE=-527.0, largestMFE=462.60, maximumIntraTradeDrawdown=-569.5

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 2408.20 | 77.68 | 100.0% | 12.0 | 9.6 | 251.73 | 0 | -403.20 | 98.00 | 3.33 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1305.00 | 65.25 | 100.0% | 14.1 | 7.7 | 168.76 | 0 | -375.70 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 1111.10 | 34.72 | 100.0% | 6.1 | 7.5 | 148.06 | 0 | -527.00 | 42.50 | 2.40 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 985.60 | 197.12 | 100.0% | 16.0 | 4.2 | 234.36 | 0 | -346.80 | 146.20 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 721.00 | 72.10 | 100.0% | 15.7 | 3.9 | 187.16 | 0 | -208.25 | 77.78 | 33.59 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 | 0.2 | 845.57 | 0 | -76.50 | 243.10 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 91.80 | 30.60 | 100.0% | 16.4 | 1.1 | 83.22 | 0 | -103.50 | 27.90 | 4.00 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 91.00 | 91.00 | 100.0% | 12.0 | 0.2 | 455.00 | 0 | -11.70 | 131.30 | 28.66 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 71.00 | 35.50 | 100.0% | 52.6 | 1.8 | 40.51 | 0 | -250.25 | 62.27 | 6.00 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |

## Strategy Entry Fingerprints

| Strategy | Enabled | Data State | Profile Set | Trades | Median Setup | Median ES-VWAP | Median RSI | Median ADX | Avg Hold Min | Slow >=12h |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 50.03 | 6.44 | 49.20 | 20.59 | 18.5 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 64.35 | 29.55 | 48.67 | 20.43 | 14.1 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 75.96 | 21.06 | 57.99 | 17.35 | 50.5 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 70.88 | 7.38 | 81.57 | 27.17 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 54.55 | 5.48 | 48.15 | 19.52 | 22.1 | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 72.50 | 16.99 | 53.58 | 42.75 | 12.0 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 78.32 | 11.24 | 80.45 | 28.97 | 52.6 | 0 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |

## MAE And MFE
- MAE: average -103.00, median -73.45, worst -527.00
- MFE: average 85.28, median 59.50, best 462.60
- Average MFE / absolute MAE: 0.83

## Intratrade Path
- Trades with path stats: 105; with intratrade price samples: 105
- Went positive before max adverse: 53.3%
- MFE happened before MAE: 9.5%
- TP touched before MAE: 1.0%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 4.2 minutes
- Median first +1.5 points: 3.0 minutes
- First 15m MFE/MAE medians: 2.40 / -2.05 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T12:36:10+00:00` -> `2026-06-26T13:56:26+00:00`.
- Strategy/profile: `charm_pin_pullback_long` / `charm_pin_pullback_long`. PnL 42.50, MAE -527.00, MFE 42.50, hold 80.3 minutes.
- Profile context: `charm_pin_pullback_long` produced 32 trades, PnL 1111.10, 0 slow >=12h trades, and 15.9% of total PnL.
- Entry state: setup=61.99, ES-VWAP=26.20, VWAP slope=0.0431, VWAP acceleration=-0.0150, RSI=42.42, ADX=17.95, structure score=4.00, higher-low=0.2500, higher-high=3.75, pullback-from-high=9.75, rolling-high distance=14.75.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=4.00, slow-risk points=0.00.
- Existing warning reason: ES pullback from high 9.75 >= 5.00; RSI slope -3.8597 <= -2.0000; ADX 17.95 <= 18.00; RSI 42.42 <= 45.00.
- Strategy selection reason: positive gamma/charm pin pullback: expectedMovePosition=0.0105, netCharm30m=-25173027, lowerFade=False, pullback=True, dynamicMaxVwapDistance=14.26.
- Intratrade path: path MFE 2.50, path MAE -28.50, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 62` would block this trade, keep 49 trades, retain 44.0% PnL, and leave worst MAE -375.70. It would block 56 trades total.
- No single candidate threshold in the report cleanly removes this tail; the closest visible guard is setup quality 61.99.

## Unscanned Feature Coverage
- Present trade columns: 144, scanned columns: 144, unscanned columns: 0
- No unscanned feature columns found. Good coverage for all present trade fields.

## Candidate Entry Quality Filters

| Scope | Condition | Kept | Blocked | Kept PnL | PnL Loss | Retained PnL | Slow Removed | Slow Left | Kept PnL/Exposure Hr | Kept Worst MAE | Score |
| --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| all | No useful single-threshold candidate found |  |  |  |  |  |  |  |  |  |  |

## Hidden MAE Signature Candidates

| Condition | Bad Trades | Bad Blocked | Good Blocked | Kept Trades | Kept PnL | PnL Loss | Retained PnL | Kept Worst MAE | Score |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| `es_structure_rising_vwap != "False"` | 20 | 7 | 13 | 85 | 5512.50 | 1479.60 | 78.8% | -527.00 | 12766.3 |
| `long_strategy != "breakout_long_1dte"` | 20 | 6 | 14 | 85 | 5687.10 | 1305.00 | 81.3% | -527.00 | 12726.9 |
| `strategy_profile != "breakout_long_1dte"` | 20 | 6 | 14 | 85 | 5687.10 | 1305.00 | 81.3% | -527.00 | 12726.9 |
| `path_half_tp_touch_minutes >= 0.183333` | 20 | 12 | 23 | 70 | 5252.50 | 1739.60 | 75.1% | -527.00 | 492.4 |
| `es_structure_pullback_from_high <= 3.25` | 20 | 8 | 25 | 72 | 5164.80 | 1827.30 | 73.9% | -403.20 | 193.6 |
| `es_structure_pullback_from_high <= 3.75` | 20 | 7 | 22 | 76 | 5309.30 | 1682.80 | 75.9% | -403.20 | 154.1 |
| `adx14 <= 36.33` | 20 | 4 | 9 | 92 | 6211.50 | 780.60 | 88.8% | -527.00 | 126.0 |
| `es_reclaim_samples <= 586` | 20 | 5 | 10 | 90 | 5798.30 | 1193.80 | 82.9% | -527.00 | 120.1 |
| `adx14 <= 28.4603` | 20 | 6 | 22 | 77 | 5372.50 | 1619.60 | 76.8% | -527.00 | 95.5 |
| `path_first_observed_points >= -0.55` | 20 | 4 | 12 | 89 | 6035.80 | 956.30 | 86.3% | -403.20 | 89.9 |
| `path_first_nonzero_move_points >= -0.55` | 20 | 4 | 12 | 89 | 6035.80 | 956.30 | 86.3% | -403.20 | 89.9 |
| `adx14 <= 26.7465` | 20 | 7 | 27 | 71 | 4901.80 | 2090.30 | 70.1% | -527.00 | 73.2 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 35898
- position_wait: 8381
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 588
- order_event: 476
- waiting_spx_quote: 415
- entry_signal: 105

## Blocked Gate Counts
- setup_quality_allowed: 14451 (disabled=14451)
- above_vwap_confirmed: 9102 (disabled=9102)
- above_vwap: 8097 (disabled=8097)
- es_structure_allowed: 7810 (disabled=7810)
- pullback: 6575 (disabled=6575)
- momentum: 4172 (disabled=4172)
- es_vwap_max_distance_allowed: 3827 (disabled=3827)
- es_vwap_slope_allowed: 3673 (disabled=3673)
- trend_strength: 3333 (disabled=3333)
- es_vwap_acceleration_allowed: 1899 (disabled=1899)
- es_rolling_high_allowed: 496 (disabled=496)
- indicator_slope_allowed: 155 (disabled=155)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 732.00 | 61.00 | 100.0% | 0.4 |
| 8 | 11 | 1303.70 | 118.52 | 100.0% | 16.6 |
| 12 | 8 | 353.30 | 44.16 | 100.0% | 12.1 |
| 14 | 8 | 770.30 | 96.29 | 100.0% | 4.0 |
| 1 | 6 | 512.20 | 85.37 | 100.0% | 3.0 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 18 | 6 | 337.60 | 56.27 | 100.0% | 10.4 |
| 9 | 6 | 279.80 | 46.63 | 100.0% | 14.0 |
| 11 | 5 | 178.20 | 35.64 | 100.0% | 12.0 |
| 19 | 5 | 252.40 | 50.48 | 100.0% | 17.0 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 2 | 4 | 211.40 | 52.85 | 100.0% | 48.6 |
| 22 | 4 | 393.90 | 98.48 | 100.0% | 14.9 |
| 7 | 4 | 241.70 | 60.42 | 100.0% | 12.0 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 10 | 2 | 55.40 | 27.70 | 100.0% | 18.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 55 | 3264.20 | 59.35 | 100.0% | 7.3 |
| 55-60 | 17 | 1336.00 | 78.59 | 100.0% | 15.3 |
| >=75 | 11 | 1009.50 | 91.77 | 100.0% | 9.9 |
| 70-75 | 9 | 447.00 | 49.67 | 100.0% | 20.0 |
| 60-65 | 8 | 392.40 | 49.05 | 100.0% | 27.6 |
| 65-70 | 5 | 543.00 | 108.60 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 41 | 2784.20 | 67.91 | 100.0% | 11.9 |
| 20-25 | 22 | 1682.50 | 76.48 | 100.0% | 12.4 |
| 25-30 | 18 | 1105.00 | 61.39 | 100.0% | 12.1 |
| 30-40 | 18 | 1079.00 | 59.94 | 100.0% | 12.0 |
| 40-50 | 5 | 301.80 | 60.36 | 100.0% | 12.0 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 105 | 6992.10 | 66.59 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 101 | 6410.60 | 63.47 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 52 | 3322.90 | 63.90 | 100.0% | 12.1 |
| -0.05-0 | 34 | 2248.60 | 66.14 | 100.0% | 8.4 |
| 0.1-0.25 | 10 | 1037.70 | 103.77 | 100.0% | 15.7 |
| 0.05-0.1 | 6 | 287.40 | 47.90 | 100.0% | 20.5 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.25--0.1 | 1 | 42.50 | 42.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 28 | 1437.70 | 51.35 | 100.0% | 7.8 |
| 2-4 | 23 | 1249.40 | 54.32 | 100.0% | 15.3 |
| 0-1 | 20 | 1637.00 | 81.85 | 100.0% | 13.9 |
| 6-8 | 14 | 1432.20 | 102.30 | 100.0% | 10.8 |
| 8-12 | 8 | 352.00 | 44.00 | 100.0% | 13.0 |
| 1-2 | 6 | 400.20 | 66.70 | 100.0% | 18.6 |
| 12-20 | 5 | 448.60 | 89.72 | 100.0% | 6.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 35 | 2490.50 | 71.16 | 100.0% | 8.7 |
| <1 | 24 | 1824.70 | 76.03 | 100.0% | 14.9 |
| 1-3 | 13 | 945.60 | 72.74 | 100.0% | 17.3 |
| 10-20 | 12 | 649.40 | 54.12 | 100.0% | 12.3 |
| 3-5 | 10 | 456.50 | 45.65 | 100.0% | 10.2 |
| 5-10 | 10 | 558.90 | 55.89 | 100.0% | 12.1 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 33 | 2549.70 | 77.26 | 100.0% | 12.1 |
| 0-1 | 21 | 1057.30 | 50.35 | 100.0% | 6.6 |
| -1-0 | 9 | 609.20 | 67.69 | 100.0% | 12.0 |
| <-3 | 9 | 373.70 | 41.52 | 100.0% | 6.7 |
| -2--1 | 8 | 528.00 | 66.00 | 100.0% | 16.6 |
| 1-2 | 7 | 488.00 | 69.71 | 100.0% | 15.0 |
| -3--2 | 6 | 242.20 | 40.37 | 100.0% | 10.2 |
| 2-3 | 6 | 702.60 | 117.10 | 100.0% | 17.8 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 37 | 2509.60 | 67.83 | 100.0% | 12.0 |
| -1-0 | 34 | 2492.00 | 73.29 | 100.0% | 13.3 |
| 1-2 | 19 | 1231.70 | 64.83 | 100.0% | 7.3 |
| -2--1 | 9 | 317.40 | 35.27 | 100.0% | 26.0 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 33 | 1717.60 | 52.05 | 100.0% | 15.0 |
| 4-8 | 21 | 2221.00 | 105.76 | 100.0% | 12.0 |
| 1-2 | 20 | 1133.00 | 56.65 | 100.0% | 7.8 |
| >=8 | 16 | 1112.00 | 69.50 | 100.0% | 15.3 |
| 0-0.5 | 8 | 388.20 | 48.53 | 100.0% | 9.5 |
| 0.5-1 | 7 | 420.30 | 60.04 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 40 | 2500.90 | 62.52 | 100.0% | 13.4 |
| 3 | 35 | 2673.60 | 76.39 | 100.0% | 12.0 |
| 5 | 29 | 1783.60 | 61.50 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 47 | 3682.00 | 78.34 | 100.0% | 13.2 |
| 2-4 | 29 | 1627.30 | 56.11 | 100.0% | 11.9 |
| 4-8 | 24 | 1504.30 | 62.68 | 100.0% | 8.9 |
| 8-12 | 5 | 178.50 | 35.70 | 100.0% | 17.3 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 40 | 2803.70 | 70.09 | 100.0% | 12.4 |
| 2-4 | 15 | 554.90 | 36.99 | 100.0% | 21.3 |
| 0.5-1 | 11 | 969.20 | 88.11 | 100.0% | 3.8 |
| 1-2 | 11 | 852.60 | 77.51 | 100.0% | 12.0 |
| 4-8 | 11 | 561.00 | 51.00 | 100.0% | 9.9 |
| >=8 | 9 | 672.50 | 74.72 | 100.0% | 12.0 |
| 0-0.5 | 8 | 578.20 | 72.28 | 100.0% | 10.8 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 38 | 2697.60 | 70.99 | 100.0% | 8.6 |
| 2-4 | 17 | 1252.60 | 73.68 | 100.0% | 11.9 |
| 4-8 | 16 | 1131.40 | 70.71 | 100.0% | 12.1 |
| 1-2 | 15 | 898.50 | 59.90 | 100.0% | 20.0 |
| >=8 | 9 | 514.00 | 57.11 | 100.0% | 14.7 |
| 0-0.5 | 6 | 245.10 | 40.85 | 100.0% | 19.0 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2665.70 | 70.15 | 100.0% | 13.9 |
| >=24 | 28 | 967.30 | 34.55 | 100.0% | 5.0 |
| 8-12 | 14 | 1499.00 | 107.07 | 100.0% | 23.5 |
| 2-4 | 8 | 591.80 | 73.97 | 100.0% | 9.3 |
| 12-16 | 7 | 381.10 | 54.44 | 100.0% | 12.0 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 34 | 2400.00 | 70.59 | 100.0% | 7.5 |
| 60-70 | 23 | 1289.70 | 56.07 | 100.0% | 12.1 |
| 70-80 | 20 | 1504.50 | 75.23 | 100.0% | 12.0 |
| 40-50 | 17 | 1247.80 | 73.40 | 100.0% | 12.7 |
| 80-90 | 11 | 550.10 | 50.01 | 100.0% | 16.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3-4 | 24 | 1423.20 | 59.30 | 100.0% | 11.9 |
| 1-2 | 23 | 1649.60 | 71.72 | 100.0% | 12.1 |
| 2-3 | 20 | 877.80 | 43.89 | 100.0% | 16.1 |
| 4-5 | 15 | 1505.00 | 100.33 | 100.0% | 9.4 |
| 5-6 | 14 | 794.30 | 56.74 | 100.0% | 7.2 |
| <1 | 9 | 742.20 | 82.47 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 105 | 6992.10 | 66.59 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 105 | 6992.10 | 66.59 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2665.70 | 70.15 | 100.0% | 13.9 |
| >=24 | 28 | 967.30 | 34.55 | 100.0% | 5.0 |
| 8-12 | 14 | 1499.00 | 107.07 | 100.0% | 23.5 |
| 2-4 | 8 | 591.80 | 73.97 | 100.0% | 9.3 |
| 12-16 | 7 | 381.10 | 54.44 | 100.0% | 12.0 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 67 | 4031.10 | 60.17 | 100.0% | 8.8 |
| 2-4 | 13 | 1193.60 | 91.82 | 100.0% | 24.9 |
| 4-6 | 8 | 583.50 | 72.94 | 100.0% | 10.9 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| >=12 | 5 | 230.80 | 46.16 | 100.0% | 16.6 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |
| 0-1 | 1 | 91.00 | 91.00 | 100.0% | 12.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 38 | 3399.80 | 89.47 | 100.0% | 10.9 |
| 15-30 | 28 | 890.50 | 31.80 | 100.0% | 19.5 |
| <5 | 25 | 1802.30 | 72.09 | 100.0% | 1.6 |
| 60-180 | 7 | 264.00 | 37.71 | 100.0% | 90.2 |
| 30-60 | 6 | 185.50 | 30.92 | 100.0% | 36.7 |
| 180-720 | 1 | 450.00 | 450.00 | 100.0% | 198.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 105 | 6992.10 | 66.59 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 79 | 5316.90 | 67.30 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1305.00 | 65.25 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 79 | 5316.90 | 67.30 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1305.00 | 65.25 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 67 | 4211.40 | 62.86 | 12.0 | 16.8 | 251.07 | 0 |
| 2026-07 | 38 | 2780.70 | 73.18 | 14.4 | 19.4 | 143.41 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 32 | 1111.10 | 34.72 | 6.1 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1305.00 | 65.25 | 14.1 |
| 3.02 | 2 | 147.60 | 73.80 | 49.9 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.13 | 1 | 59.50 | 59.50 | 12.0 |
| 3.14 | 1 | 108.50 | 108.50 | 6.5 |
| 3.19 | 1 | 35.00 | 35.00 | 26.0 |
| 3.22 | 1 | 118.80 | 118.80 | 6.6 |
| 3.26 | 1 | 118.80 | 118.80 | 3.8 |
| 3.30 | 1 | 118.80 | 118.80 | 0.1 |
| 3.31 | 2 | 69.00 | 34.50 | 17.2 |
| 3.33 | 1 | 36.00 | 36.00 | 29.9 |
| 3.34 | 1 | 36.00 | 36.00 | 155.4 |
| 3.35 | 1 | 119.00 | 119.00 | 8.4 |
| 3.43 | 1 | 46.80 | 46.80 | 12.7 |
| 3.44 | 1 | 119.00 | 119.00 | 7.3 |
| 3.46 | 1 | 136.50 | 136.50 | 8.8 |
| 3.48 | 1 | 122.50 | 122.50 | 5.8 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.60 | 6 | 541.70 | 90.28 | 9.5 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 3 | 278.40 | 92.80 | 23.3 |
| 12.00 | 5 | 985.60 | 197.12 | 16.0 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 15.00 | 1 | 45.50 | 45.50 | 44.6 |
| 16.25 | 1 | 35.00 | 35.00 | 23.6 |
| 23.75 | 1 | 35.00 | 35.00 | 57.7 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 28.66 | 1 | 91.00 | 91.00 | 12.0 |
| 38.75 | 2 | 125.80 | 62.90 | 14.7 |
| 48.62 | 2 | 71.00 | 35.50 | 19.9 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
