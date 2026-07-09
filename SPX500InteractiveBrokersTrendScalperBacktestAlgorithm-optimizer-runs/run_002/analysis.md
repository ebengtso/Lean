# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_002/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_002/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 105
- Entry signals: 105
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 7953
- Total paired trade PnL: 6884.40
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 19.6 minutes

## Lean Runtime Statistics
- Equity: $106,884.40
- Net Profit: $6,884.40
- Return: 6.88 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $45,539,395.60

## Risk And Efficiency
- Exposure hours: 34.4
- PnL per exposure hour: 200.27
- Calendar span days: 12.3
- PnL per calendar day: 558.91
- Trades per calendar day: 8.52
- Exposure share of calendar time: 11.6%
- Growth quality score: 10902.1
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 64
- Fast PnL per exposure hour: 760.60

## Pullback Broken Structure Veto
- Blocked signal rows: 1226
- Blocked by profile: `{"charm_pin_pullback_long": 1174, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 1, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 34, "charm_wall_breakaway_long": 5, "pullback_long": 31, "pullback_long_no_0dte": 2, "squeeze_long": 10, "squeeze_long_no_0dte": 1}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1298.6999999999907, "breakout_long_no_0dte": 36.0, "call_wall_acceptance_long": 91.0, "charm_pin_pullback_long": 1237.7000000001144, "charm_wall_breakaway_long": 985.5999999999876, "pullback_long": 2404.600000000193, "pullback_long_no_0dte": 73.79999999999018, "squeeze_long": 721.0000000000064, "squeeze_long_no_0dte": 36.0}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=29.9160, sortinoRatio=0, alpha=0, beta=0, informationRatio=30.4996, drawdown=0.004
- Trades: sharpeRatio=1.0092, averageMAE=-99.1562, averageMFE=83.7776, largestMAE=-527.0, largestMFE=462.60, maximumIntraTradeDrawdown=-569.5

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 2404.60 | 77.57 | 100.0% | 12.0 | 9.6 | 251.35 | 0 | -403.20 | 98.00 | 3.33 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1298.70 | 64.93 | 100.0% | 14.1 | 7.7 | 167.94 | 0 | -375.70 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 1237.70 | 36.40 | 100.0% | 5.3 | 7.5 | 164.67 | 0 | -527.00 | 42.50 | 2.40 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 985.60 | 197.12 | 100.0% | 16.0 | 4.2 | 234.36 | 0 | -346.80 | 146.20 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 721.00 | 72.10 | 100.0% | 15.7 | 3.9 | 187.16 | 0 | -208.25 | 77.78 | 33.59 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 91.00 | 91.00 | 100.0% | 12.0 | 0.2 | 455.00 | 0 | -11.70 | 131.30 | 28.66 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 73.80 | 36.90 | 100.0% | 14.1 | 0.5 | 156.93 | 0 | -26.10 | 41.85 | 3.55 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 1 | 36.00 | 36.00 | 100.0% | 24.0 | 0.4 | 90.13 | 0 | -99.00 | 52.20 | 6.00 |
| squeeze_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 1 | 36.00 | 36.00 | 100.0% | 25.9 | 0.4 | 83.34 | 0 | -163.80 | 52.20 | 4.00 |
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
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 66.16 | 29.56 | 49.07 | 19.65 | 13.3 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 75.96 | 21.06 | 57.99 | 17.35 | 50.5 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 72.50 | 16.99 | 53.58 | 42.75 | 12.0 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 51.18 | 3.27 | 58.92 | 18.65 | 14.1 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 1 | 74.61 | 8.46 | 61.87 | 31.04 | 24.0 | 0 |
| squeeze_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 1 | 77.60 | 14.31 | 69.81 | 20.48 | 25.9 | 0 |
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
- MAE: average -100.11, median -69.53, worst -527.00
- MFE: average 83.78, median 56.10, best 462.60
- Average MFE / absolute MAE: 0.84

## Intratrade Path
- Trades with path stats: 105; with intratrade price samples: 105
- Went positive before max adverse: 52.4%
- MFE happened before MAE: 9.5%
- TP touched before MAE: 1.0%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 3.8 minutes
- Median first +1.5 points: 2.9 minutes
- First 15m MFE/MAE medians: 2.40 / -1.90 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T12:36:10+00:00` -> `2026-06-26T13:56:26+00:00`.
- Strategy/profile: `charm_pin_pullback_long` / `charm_pin_pullback_long`. PnL 42.50, MAE -527.00, MFE 42.50, hold 80.3 minutes.
- Profile context: `charm_pin_pullback_long` produced 34 trades, PnL 1237.70, 0 slow >=12h trades, and 18.0% of total PnL.
- Entry state: setup=61.99, ES-VWAP=26.20, VWAP slope=0.0431, VWAP acceleration=-0.0150, RSI=42.42, ADX=17.95, structure score=4.00, higher-low=0.2500, higher-high=3.75, pullback-from-high=9.75, rolling-high distance=14.75.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=4.00, slow-risk points=0.00.
- Existing warning reason: ES pullback from high 9.75 >= 5.00; RSI slope -3.8597 <= -2.0000; ADX 17.95 <= 18.00; RSI 42.42 <= 45.00.
- Strategy selection reason: positive gamma/charm pin pullback: expectedMovePosition=0.0105, netCharm30m=-25173027, lowerFade=False, pullback=True, dynamicMaxVwapDistance=17.83.
- Intratrade path: path MFE 2.50, path MAE -28.50, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 62` would block this trade, keep 50 trades, retain 43.5% PnL, and leave worst MAE -375.70. It would block 55 trades total.
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
| `es_structure_rising_vwap != "False"` | 20 | 6 | 12 | 87 | 5649.20 | 1235.20 | 82.1% | -527.00 | 12751.4 |
| `long_strategy != "breakout_long_1dte"` | 20 | 6 | 14 | 85 | 5585.70 | 1298.70 | 81.1% | -527.00 | 12728.1 |
| `strategy_profile != "breakout_long_1dte"` | 20 | 6 | 14 | 85 | 5585.70 | 1298.70 | 81.1% | -527.00 | 12728.1 |
| `path_half_tp_touch_minutes >= 0.183333` | 20 | 12 | 23 | 70 | 5123.00 | 1761.40 | 74.4% | -527.00 | 488.4 |
| `option_strike_map_target_1_strike >= 7475` | 20 | 5 | 9 | 91 | 6015.70 | 868.70 | 87.4% | -403.20 | 180.1 |
| `option_strike_map_underlying_price >= 7443.25` | 20 | 4 | 9 | 92 | 6056.50 | 827.90 | 88.0% | -403.20 | 117.5 |
| `option_strike_map_target_1_strike >= 7500` | 20 | 6 | 25 | 74 | 5398.60 | 1485.80 | 78.4% | -403.20 | 115.1 |
| `path_first_observed_seconds >= 2` | 20 | 5 | 16 | 84 | 5698.60 | 1185.80 | 82.8% | -527.00 | 112.6 |
| `es_structure_higher_low_distance >= -1` | 20 | 5 | 19 | 81 | 5558.30 | 1326.10 | 80.7% | -527.00 | 82.8 |
| `path_first_observed_points >= -0.55` | 20 | 4 | 12 | 89 | 5881.90 | 1002.50 | 85.4% | -403.20 | 81.5 |
| `path_first_nonzero_move_points >= -0.55` | 20 | 4 | 12 | 89 | 5881.90 | 1002.50 | 85.4% | -403.20 | 81.5 |
| `option_strike_map_underlying_price >= 7492` | 20 | 6 | 30 | 69 | 5164.00 | 1720.40 | 75.0% | -403.20 | 65.3 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36326
- position_wait: 7953
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 591
- order_event: 475
- waiting_spx_quote: 415
- entry_signal: 105

## Blocked Gate Counts
- setup_quality_allowed: 14491 (disabled=14491)
- above_vwap_confirmed: 9088 (disabled=9088)
- above_vwap: 8097 (disabled=8097)
- es_structure_allowed: 7799 (disabled=7799)
- pullback: 6575 (disabled=6575)
- momentum: 4172 (disabled=4172)
- es_vwap_max_distance_allowed: 3828 (disabled=3828)
- es_vwap_slope_allowed: 3673 (disabled=3673)
- trend_strength: 3333 (disabled=3333)
- es_vwap_acceleration_allowed: 1899 (disabled=1899)
- es_rolling_high_allowed: 495 (disabled=495)
- indicator_slope_allowed: 155 (disabled=155)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 728.40 | 60.70 | 100.0% | 0.4 |
| 8 | 11 | 1303.70 | 118.52 | 100.0% | 16.6 |
| 14 | 10 | 851.90 | 85.19 | 100.0% | 2.1 |
| 12 | 8 | 353.30 | 44.16 | 100.0% | 12.1 |
| 1 | 6 | 512.20 | 85.37 | 100.0% | 3.0 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 18 | 6 | 337.60 | 56.27 | 100.0% | 10.4 |
| 9 | 6 | 325.80 | 54.30 | 100.0% | 14.0 |
| 11 | 5 | 178.20 | 35.64 | 100.0% | 12.0 |
| 19 | 5 | 252.40 | 50.48 | 100.0% | 17.0 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 2 | 4 | 210.40 | 52.60 | 100.0% | 48.6 |
| 5 | 4 | 227.10 | 56.78 | 100.0% | 18.0 |
| 7 | 4 | 241.70 | 60.42 | 100.0% | 12.0 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 22 | 3 | 185.50 | 61.83 | 100.0% | 15.0 |
| 10 | 2 | 55.40 | 27.70 | 100.0% | 18.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 146.20 | 73.10 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 56 | 3369.20 | 60.16 | 100.0% | 7.2 |
| 55-60 | 17 | 1332.90 | 78.41 | 100.0% | 15.3 |
| 60-65 | 9 | 427.20 | 47.47 | 100.0% | 25.7 |
| >=75 | 9 | 766.10 | 85.12 | 100.0% | 5.8 |
| 70-75 | 8 | 411.00 | 51.38 | 100.0% | 18.7 |
| 65-70 | 6 | 578.00 | 96.33 | 100.0% | 20.6 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 43 | 2858.10 | 66.47 | 100.0% | 8.8 |
| 20-25 | 23 | 1718.50 | 74.72 | 100.0% | 12.7 |
| 30-40 | 19 | 1157.80 | 60.94 | 100.0% | 12.0 |
| 25-30 | 14 | 808.60 | 57.76 | 100.0% | 12.0 |
| 40-50 | 5 | 301.80 | 60.36 | 100.0% | 12.0 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 105 | 6884.40 | 65.57 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 101 | 6302.90 | 62.40 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 51 | 3300.80 | 64.72 | 100.0% | 12.0 |
| -0.05-0 | 36 | 2326.60 | 64.63 | 100.0% | 7.8 |
| 0.1-0.25 | 8 | 794.30 | 99.29 | 100.0% | 14.3 |
| 0.05-0.1 | 7 | 322.20 | 46.03 | 100.0% | 23.6 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 26.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 31 | 1550.50 | 50.02 | 100.0% | 7.1 |
| 2-4 | 21 | 1195.40 | 56.92 | 100.0% | 12.0 |
| 0-1 | 19 | 1424.50 | 74.97 | 100.0% | 13.2 |
| 6-8 | 14 | 1432.20 | 102.30 | 100.0% | 10.8 |
| 8-12 | 8 | 397.00 | 49.62 | 100.0% | 13.0 |
| 1-2 | 6 | 401.20 | 66.87 | 100.0% | 18.6 |
| 12-20 | 5 | 448.60 | 89.72 | 100.0% | 6.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 35 | 2490.50 | 71.16 | 100.0% | 8.7 |
| <1 | 22 | 1577.20 | 71.69 | 100.0% | 14.1 |
| 1-3 | 14 | 980.40 | 70.03 | 100.0% | 19.0 |
| 5-10 | 12 | 640.50 | 53.38 | 100.0% | 10.3 |
| 10-20 | 11 | 627.80 | 57.07 | 100.0% | 12.0 |
| 3-5 | 10 | 501.50 | 50.15 | 100.0% | 10.2 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 31 | 2305.30 | 74.36 | 100.0% | 12.0 |
| 0-1 | 20 | 1018.00 | 50.90 | 100.0% | 6.0 |
| -1-0 | 9 | 609.20 | 67.69 | 100.0% | 12.0 |
| <-3 | 9 | 418.70 | 46.52 | 100.0% | 6.7 |
| -2--1 | 8 | 524.40 | 65.55 | 100.0% | 16.6 |
| -3--2 | 8 | 323.80 | 40.48 | 100.0% | 6.8 |
| 1-2 | 7 | 506.00 | 72.29 | 100.0% | 15.0 |
| 2-3 | 7 | 737.60 | 105.37 | 100.0% | 20.0 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 36 | 2324.50 | 64.57 | 100.0% | 10.9 |
| -1-0 | 33 | 2498.40 | 75.71 | 100.0% | 12.7 |
| 1-2 | 21 | 1302.70 | 62.03 | 100.0% | 8.4 |
| -2--1 | 9 | 317.40 | 35.27 | 100.0% | 26.0 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 32 | 1699.60 | 53.11 | 100.0% | 13.8 |
| 4-8 | 21 | 2259.70 | 107.60 | 100.0% | 12.0 |
| 1-2 | 20 | 1133.00 | 56.65 | 100.0% | 7.8 |
| >=8 | 15 | 905.60 | 60.37 | 100.0% | 16.0 |
| 0-0.5 | 10 | 466.20 | 46.62 | 100.0% | 4.5 |
| 0.5-1 | 7 | 420.30 | 60.04 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 36 | 2244.90 | 62.36 | 100.0% | 12.0 |
| 3 | 35 | 2672.60 | 76.36 | 100.0% | 12.0 |
| 5 | 33 | 1932.90 | 58.57 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 45 | 3452.50 | 76.72 | 100.0% | 12.1 |
| 2-4 | 28 | 1587.70 | 56.70 | 100.0% | 11.9 |
| 4-8 | 27 | 1620.70 | 60.03 | 100.0% | 8.5 |
| 8-12 | 5 | 223.50 | 44.70 | 100.0% | 17.3 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 39 | 2766.70 | 70.94 | 100.0% | 12.1 |
| 2-4 | 17 | 634.30 | 37.31 | 100.0% | 20.0 |
| 0.5-1 | 12 | 998.50 | 83.21 | 100.0% | 4.8 |
| 4-8 | 12 | 597.00 | 49.75 | 100.0% | 10.9 |
| 1-2 | 10 | 645.20 | 64.52 | 100.0% | 11.9 |
| >=8 | 8 | 682.50 | 85.31 | 100.0% | 12.0 |
| 0-0.5 | 7 | 560.20 | 80.03 | 100.0% | 9.7 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 37 | 2676.00 | 72.32 | 100.0% | 8.5 |
| 2-4 | 19 | 1333.20 | 70.17 | 100.0% | 9.4 |
| 4-8 | 17 | 1166.20 | 68.60 | 100.0% | 12.1 |
| 1-2 | 15 | 894.40 | 59.63 | 100.0% | 20.0 |
| >=8 | 7 | 316.60 | 45.23 | 100.0% | 12.1 |
| 0-0.5 | 6 | 245.10 | 40.85 | 100.0% | 19.0 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 36 | 2436.20 | 67.67 | 100.0% | 12.9 |
| >=24 | 30 | 1048.90 | 34.96 | 100.0% | 3.8 |
| 8-12 | 13 | 1459.20 | 112.25 | 100.0% | 23.6 |
| 12-16 | 8 | 462.10 | 57.76 | 100.0% | 13.0 |
| 2-4 | 8 | 590.80 | 73.85 | 100.0% | 9.3 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 33 | 2377.90 | 72.06 | 100.0% | 6.6 |
| 60-70 | 25 | 1370.30 | 54.81 | 100.0% | 12.0 |
| 70-80 | 20 | 1378.10 | 68.91 | 100.0% | 12.0 |
| 40-50 | 17 | 1244.20 | 73.19 | 100.0% | 12.7 |
| 80-90 | 10 | 513.90 | 51.39 | 100.0% | 15.8 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3-4 | 24 | 1464.60 | 61.03 | 100.0% | 11.9 |
| 2-3 | 22 | 958.40 | 43.56 | 100.0% | 15.8 |
| 1-2 | 20 | 1388.20 | 69.41 | 100.0% | 12.0 |
| 4-5 | 15 | 1505.00 | 100.33 | 100.0% | 9.4 |
| 5-6 | 14 | 794.30 | 56.74 | 100.0% | 7.2 |
| <1 | 10 | 773.90 | 77.39 | 100.0% | 19.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 105 | 6884.40 | 65.57 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 105 | 6884.40 | 65.57 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 36 | 2436.20 | 67.67 | 100.0% | 12.9 |
| >=24 | 30 | 1048.90 | 34.96 | 100.0% | 3.8 |
| 8-12 | 13 | 1459.20 | 112.25 | 100.0% | 23.6 |
| 12-16 | 8 | 462.10 | 57.76 | 100.0% | 13.0 |
| 2-4 | 8 | 590.80 | 73.85 | 100.0% | 9.3 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 68 | 4136.10 | 60.83 | 100.0% | 8.6 |
| 2-4 | 13 | 1188.30 | 91.41 | 100.0% | 24.9 |
| 4-6 | 9 | 618.50 | 68.72 | 100.0% | 12.0 |
| 8-12 | 5 | 478.70 | 95.74 | 100.0% | 12.1 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| >=12 | 3 | 159.80 | 53.27 | 100.0% | 16.0 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |
| 0-1 | 1 | 91.00 | 91.00 | 100.0% | 12.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 37 | 3233.80 | 87.40 | 100.0% | 9.9 |
| 15-30 | 29 | 924.30 | 31.87 | 100.0% | 20.0 |
| <5 | 27 | 1880.80 | 69.66 | 100.0% | 1.2 |
| 60-180 | 6 | 228.00 | 38.00 | 100.0% | 101.3 |
| 30-60 | 5 | 167.50 | 33.50 | 100.0% | 35.4 |
| 180-720 | 1 | 450.00 | 450.00 | 100.0% | 198.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 105 | 6884.40 | 65.57 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 81 | 5439.90 | 67.16 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1298.70 | 64.93 | 100.0% | 14.1 |
| STALE_0DTE | 4 | 145.80 | 36.45 | 100.0% | 20.2 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 81 | 5439.90 | 67.16 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1298.70 | 64.93 | 100.0% | 14.1 |
| STALE_0DTE | 4 | 145.80 | 36.45 | 100.0% | 20.2 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 67 | 4090.30 | 61.05 | 9.9 | 16.2 | 253.24 | 0 |
| 2026-07 | 38 | 2794.10 | 73.53 | 14.4 | 18.2 | 153.32 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 34 | 1237.70 | 36.40 | 5.3 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1298.70 | 64.93 | 14.1 |
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
| 3.60 | 6 | 538.10 | 89.68 | 9.5 |
| 4.00 | 2 | 54.00 | 27.00 | 21.1 |
| 6.00 | 1 | 36.00 | 36.00 | 24.0 |
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
