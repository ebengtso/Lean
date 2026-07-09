# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_016/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_016/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 108
- Entry signals: 108
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8389
- Total paired trade PnL: 6830.30
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 20.1 minutes

## Lean Runtime Statistics
- Equity: $106,830.30
- Net Profit: $6,830.30
- Return: 6.83 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $46,498,469.50

## Risk And Efficiency
- Exposure hours: 36.2
- PnL per exposure hour: 188.70
- Calendar span days: 12.3
- PnL per calendar day: 554.52
- Trades per calendar day: 8.77
- Exposure share of calendar time: 12.2%
- Growth quality score: 10860.3
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 66
- Fast PnL per exposure hour: 737.19

## Pullback Broken Structure Veto
- Blocked signal rows: 1241
- Blocked by profile: `{"charm_pin_pullback_long": 1189, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "charm_pin_pullback_long": 37, "charm_wall_breakaway_long": 2, "pullback_long": 32, "pullback_long_no_0dte": 3, "squeeze_long": 11}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1310.1999999999916, "breakout_long_no_0dte": 278.40000000001237, "charm_pin_pullback_long": 1379.5000000001428, "charm_wall_breakaway_long": 485.0, "pullback_long": 2530.400000000218, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 755.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=31.4790, sortinoRatio=0, alpha=0, beta=0, informationRatio=32.1196, drawdown=0.004
- Trades: sharpeRatio=1.1191, averageMAE=-99.1185, averageMFE=82.1912, largestMAE=-527.0, largestMFE=462.60, maximumIntraTradeDrawdown=-569.5

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 2530.40 | 79.08 | 100.0% | 12.0 | 9.8 | 259.11 | 0 | -403.20 | 102.10 | 3.33 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 37 | 1379.50 | 37.28 | 100.0% | 5.1 | 8.0 | 173.26 | 0 | -527.00 | 42.50 | 2.40 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1310.20 | 65.51 | 100.0% | 14.1 | 7.7 | 169.43 | 0 | -375.70 | 79.88 | 3.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 11 | 755.00 | 68.64 | 100.0% | 14.0 | 4.1 | 186.32 | 0 | -208.25 | 89.25 | 38.75 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 2 | 485.00 | 242.50 | 100.0% | 107.5 | 3.6 | 135.39 | 0 | -201.25 | 254.93 | 12.00 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 | 0.2 | 845.57 | 0 | -76.50 | 243.10 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 91.80 | 30.60 | 100.0% | 16.4 | 1.1 | 83.22 | 0 | -103.50 | 27.90 | 4.00 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 71.00 | 35.50 | 100.0% | 52.6 | 1.8 | 40.51 | 0 | -250.25 | 62.27 | 6.00 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |

## Strategy Entry Fingerprints

| Strategy | Enabled | Data State | Profile Set | Trades | Median Setup | Median ES-VWAP | Median RSI | Median ADX | Avg Hold Min | Slow >=12h |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 50.21 | 6.57 | 48.90 | 20.37 | 18.3 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 37 | 65.52 | 29.55 | 48.91 | 20.35 | 12.9 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 11 | 69.34 | 11.85 | 67.57 | 21.40 | 22.1 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 2 | 69.29 | 15.88 | 63.78 | 15.82 | 107.5 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 70.88 | 7.38 | 81.57 | 27.17 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 54.55 | 5.48 | 48.15 | 19.52 | 22.1 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 78.32 | 11.24 | 80.45 | 28.97 | 52.6 | 0 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |

## MAE And MFE
- MAE: average -100.04, median -73.10, worst -527.00
- MFE: average 82.19, median 60.38, best 462.60
- Average MFE / absolute MAE: 0.82

## Intratrade Path
- Trades with path stats: 108; with intratrade price samples: 108
- Went positive before max adverse: 51.9%
- MFE happened before MAE: 9.3%
- TP touched before MAE: 0.9%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 3.3 minutes
- Median first +1.5 points: 3.0 minutes
- First 15m MFE/MAE medians: 2.40 / -2.00 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T12:36:10+00:00` -> `2026-06-26T13:56:26+00:00`.
- Strategy/profile: `charm_pin_pullback_long` / `charm_pin_pullback_long`. PnL 42.50, MAE -527.00, MFE 42.50, hold 80.3 minutes.
- Profile context: `charm_pin_pullback_long` produced 37 trades, PnL 1379.50, 0 slow >=12h trades, and 20.2% of total PnL.
- Entry state: setup=61.99, ES-VWAP=26.20, VWAP slope=0.0431, VWAP acceleration=-0.0150, RSI=42.42, ADX=17.95, structure score=4.00, higher-low=0.2500, higher-high=3.75, pullback-from-high=9.75, rolling-high distance=14.75.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=4.00, slow-risk points=0.00.
- Existing warning reason: ES pullback from high 9.75 >= 5.00; RSI slope -3.8597 <= -2.0000; ADX 17.95 <= 18.00; RSI 42.42 <= 45.00.
- Strategy selection reason: positive gamma/charm pin pullback: expectedMovePosition=0.0105, netCharm30m=-25173027, lowerFade=False, pullback=True, dynamicMaxVwapDistance=17.83.
- Intratrade path: path MFE 2.50, path MAE -28.50, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 62` would block this trade, keep 49 trades, retain 39.4% PnL, and leave worst MAE -375.70. It would block 59 trades total.
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
| `long_strategy != "breakout_long_1dte"` | 21 | 6 | 14 | 88 | 5520.10 | 1310.20 | 80.8% | -527.00 | 12707.5 |
| `strategy_profile != "breakout_long_1dte"` | 21 | 6 | 14 | 88 | 5520.10 | 1310.20 | 80.8% | -527.00 | 12707.5 |
| `es_structure_rising_vwap != "False"` | 21 | 6 | 14 | 88 | 5361.20 | 1469.10 | 78.5% | -527.00 | 12675.8 |
| `path_half_tp_touch_minutes >= 0.183333` | 21 | 12 | 22 | 74 | 5188.50 | 1641.80 | 76.0% | -527.00 | 471.5 |
| `es_structure_higher_low_distance >= -1` | 21 | 6 | 18 | 84 | 5528.20 | 1302.10 | 80.9% | -527.00 | 138.6 |
| `option_strike_map_target_1_strike >= 7475` | 21 | 5 | 11 | 92 | 5720.30 | 1110.00 | 83.7% | -403.20 | 117.0 |
| `es_structure_pullback_from_high <= 3.25` | 21 | 7 | 29 | 72 | 5093.40 | 1736.90 | 74.6% | -403.20 | 110.5 |
| `es_structure_higher_low_distance >= -0.5` | 21 | 7 | 22 | 79 | 4949.40 | 1880.90 | 72.5% | -527.00 | 95.1 |
| `es_structure_pullback_from_high <= 3.75` | 21 | 6 | 26 | 76 | 5237.90 | 1592.40 | 76.7% | -403.20 | 74.4 |
| `option_strike_map_target_1_strike >= 7500` | 21 | 6 | 27 | 75 | 5103.20 | 1727.10 | 74.7% | -403.20 | 48.6 |
| `option_strike_map_atm_straddle_points >= 56.8` | 21 | 5 | 20 | 83 | 5328.20 | 1502.10 | 78.0% | -527.00 | 33.0 |
| `es_structure_score <= 4` | 21 | 6 | 25 | 77 | 4962.00 | 1868.30 | 72.6% | -527.00 | 26.2 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 35890
- position_wait: 8389
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 587
- order_event: 487
- waiting_spx_quote: 414
- entry_signal: 108

## Blocked Gate Counts
- setup_quality_allowed: 14373 (disabled=14373)
- above_vwap_confirmed: 9038 (disabled=9038)
- above_vwap: 8021 (disabled=8021)
- es_structure_allowed: 7702 (disabled=7702)
- pullback: 6717 (disabled=6717)
- momentum: 4045 (disabled=4045)
- es_vwap_max_distance_allowed: 3888 (disabled=3888)
- es_vwap_slope_allowed: 3377 (disabled=3377)
- trend_strength: 3348 (disabled=3348)
- es_vwap_acceleration_allowed: 1595 (disabled=1595)
- es_rolling_high_allowed: 273 (disabled=273)
- indicator_slope_allowed: 137 (disabled=137)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 728.40 | 60.70 | 100.0% | 0.4 |
| 8 | 11 | 1304.70 | 118.61 | 100.0% | 16.6 |
| 14 | 10 | 459.10 | 45.91 | 100.0% | 1.5 |
| 12 | 7 | 262.30 | 37.47 | 100.0% | 12.2 |
| 15 | 7 | 452.10 | 64.59 | 100.0% | 6.5 |
| 1 | 6 | 515.30 | 85.88 | 100.0% | 3.0 |
| 11 | 6 | 195.20 | 32.53 | 100.0% | 14.9 |
| 18 | 6 | 337.60 | 56.27 | 100.0% | 10.4 |
| 19 | 5 | 252.40 | 50.48 | 100.0% | 17.0 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 9 | 5 | 290.80 | 58.16 | 100.0% | 12.0 |
| 2 | 4 | 214.50 | 53.63 | 100.0% | 48.6 |
| 22 | 4 | 392.90 | 98.23 | 100.0% | 14.9 |
| 7 | 4 | 241.70 | 60.42 | 100.0% | 12.0 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 10 | 3 | 181.20 | 60.40 | 100.0% | 14.0 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 59 | 3523.00 | 59.71 | 100.0% | 7.2 |
| 55-60 | 15 | 1254.40 | 83.63 | 100.0% | 15.3 |
| >=75 | 11 | 1012.60 | 92.05 | 100.0% | 9.9 |
| 60-65 | 9 | 429.50 | 47.72 | 100.0% | 25.7 |
| 70-75 | 9 | 448.00 | 49.78 | 100.0% | 20.0 |
| 65-70 | 5 | 162.80 | 32.56 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 43 | 2923.40 | 67.99 | 100.0% | 8.8 |
| 20-25 | 22 | 1306.40 | 59.38 | 100.0% | 12.4 |
| 25-30 | 20 | 1226.10 | 61.31 | 100.0% | 12.0 |
| 30-40 | 18 | 1124.00 | 62.44 | 100.0% | 12.0 |
| 40-50 | 4 | 210.80 | 52.70 | 100.0% | 13.8 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 108 | 6830.30 | 63.24 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 104 | 6628.00 | 63.73 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 185.30 | 61.77 | 100.0% | 5.8 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 51 | 3281.50 | 64.34 | 100.0% | 12.0 |
| -0.05-0 | 36 | 2252.60 | 62.57 | 100.0% | 7.8 |
| 0.1-0.25 | 10 | 658.50 | 65.85 | 100.0% | 15.7 |
| 0.05-0.1 | 6 | 287.40 | 47.90 | 100.0% | 20.5 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.1--0.05 | 1 | 125.80 | 125.80 | 100.0% | 11.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |
| <-0.25 | 1 | 84.00 | 84.00 | 100.0% | 2.4 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 29 | 1468.10 | 50.62 | 100.0% | 5.8 |
| 2-4 | 24 | 1287.50 | 53.65 | 100.0% | 13.6 |
| 0-1 | 19 | 1605.10 | 84.48 | 100.0% | 13.2 |
| 6-8 | 14 | 1053.00 | 75.21 | 100.0% | 10.3 |
| 8-12 | 8 | 323.00 | 40.38 | 100.0% | 15.7 |
| 12-20 | 7 | 658.40 | 94.06 | 100.0% | 6.6 |
| 1-2 | 6 | 400.20 | 66.70 | 100.0% | 18.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 35 | 2419.60 | 69.13 | 100.0% | 8.7 |
| <1 | 23 | 1793.80 | 77.99 | 100.0% | 14.7 |
| 5-10 | 14 | 850.30 | 60.74 | 100.0% | 10.3 |
| 1-3 | 13 | 566.40 | 43.57 | 100.0% | 17.3 |
| 10-20 | 13 | 679.80 | 52.29 | 100.0% | 12.0 |
| 3-5 | 9 | 453.90 | 50.43 | 100.0% | 8.4 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 32 | 2082.60 | 65.08 | 100.0% | 12.4 |
| 0-1 | 21 | 1107.30 | 52.73 | 100.0% | 5.5 |
| -1-0 | 9 | 612.30 | 68.03 | 100.0% | 12.0 |
| 1-2 | 9 | 647.80 | 71.98 | 100.0% | 12.0 |
| -2--1 | 8 | 524.40 | 65.55 | 100.0% | 16.6 |
| -3--2 | 8 | 323.80 | 40.48 | 100.0% | 6.8 |
| <-3 | 8 | 371.10 | 46.39 | 100.0% | 5.8 |
| 2-3 | 7 | 719.60 | 102.80 | 100.0% | 20.0 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 40 | 2299.10 | 57.48 | 100.0% | 11.9 |
| -1-0 | 35 | 2585.20 | 73.86 | 100.0% | 14.0 |
| 1-2 | 18 | 1187.20 | 65.96 | 100.0% | 6.5 |
| -2--1 | 9 | 317.40 | 35.27 | 100.0% | 26.0 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 35 | 1818.60 | 51.96 | 100.0% | 15.0 |
| 1-2 | 20 | 1133.00 | 56.65 | 100.0% | 7.8 |
| 4-8 | 20 | 1801.00 | 90.05 | 100.0% | 10.9 |
| >=8 | 16 | 1191.20 | 74.45 | 100.0% | 14.4 |
| 0-0.5 | 10 | 466.20 | 46.62 | 100.0% | 4.5 |
| 0.5-1 | 7 | 420.30 | 60.04 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 39 | 2590.60 | 66.43 | 100.0% | 12.0 |
| 3 | 37 | 2337.40 | 63.17 | 100.0% | 12.0 |
| 5 | 31 | 1868.30 | 60.27 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 46 | 3596.20 | 78.18 | 100.0% | 12.6 |
| 2-4 | 30 | 1641.70 | 54.72 | 100.0% | 11.9 |
| 4-8 | 25 | 1159.10 | 46.36 | 100.0% | 7.2 |
| 8-12 | 5 | 223.50 | 44.70 | 100.0% | 17.3 |
| 12-16 | 1 | 84.00 | 84.00 | 100.0% | 2.4 |
| 16-24 | 1 | 125.80 | 125.80 | 100.0% | 11.9 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 40 | 2399.50 | 59.99 | 100.0% | 12.4 |
| 2-4 | 18 | 670.50 | 37.25 | 100.0% | 18.1 |
| 1-2 | 12 | 981.50 | 81.79 | 100.0% | 12.0 |
| 0.5-1 | 11 | 965.60 | 87.78 | 100.0% | 3.8 |
| 4-8 | 10 | 517.50 | 51.75 | 100.0% | 7.4 |
| >=8 | 9 | 717.50 | 79.72 | 100.0% | 12.0 |
| 0-0.5 | 8 | 578.20 | 72.28 | 100.0% | 10.8 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 39 | 2654.00 | 68.05 | 100.0% | 8.7 |
| 2-4 | 18 | 923.10 | 51.28 | 100.0% | 3.7 |
| 4-8 | 16 | 1134.50 | 70.91 | 100.0% | 12.1 |
| 1-2 | 15 | 898.50 | 59.90 | 100.0% | 20.0 |
| 0-0.5 | 8 | 454.90 | 56.86 | 100.0% | 16.9 |
| >=8 | 8 | 512.40 | 64.05 | 100.0% | 15.7 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2671.90 | 70.31 | 100.0% | 13.9 |
| >=24 | 31 | 1065.90 | 34.38 | 100.0% | 4.8 |
| 8-12 | 15 | 1621.20 | 108.08 | 100.0% | 23.3 |
| 12-16 | 8 | 496.50 | 62.06 | 100.0% | 12.0 |
| 2-4 | 8 | 590.80 | 73.85 | 100.0% | 9.3 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |
| 16-24 | 4 | 159.10 | 39.78 | 100.0% | 7.0 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 36 | 2608.80 | 72.47 | 100.0% | 7.5 |
| 60-70 | 25 | 1346.90 | 53.88 | 100.0% | 12.1 |
| 70-80 | 19 | 1079.30 | 56.81 | 100.0% | 12.0 |
| 40-50 | 17 | 1244.20 | 73.19 | 100.0% | 12.7 |
| 80-90 | 11 | 551.10 | 50.10 | 100.0% | 16.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 23 | 1652.70 | 71.86 | 100.0% | 12.1 |
| 2-3 | 23 | 1085.20 | 47.18 | 100.0% | 12.0 |
| 3-4 | 23 | 1343.00 | 58.39 | 100.0% | 11.9 |
| 4-5 | 15 | 1125.80 | 75.05 | 100.0% | 5.5 |
| 5-6 | 15 | 878.30 | 58.55 | 100.0% | 7.2 |
| <1 | 9 | 745.30 | 82.81 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 108 | 6830.30 | 63.24 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 108 | 6830.30 | 63.24 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2671.90 | 70.31 | 100.0% | 13.9 |
| >=24 | 31 | 1065.90 | 34.38 | 100.0% | 4.8 |
| 8-12 | 15 | 1621.20 | 108.08 | 100.0% | 23.3 |
| 12-16 | 8 | 496.50 | 62.06 | 100.0% | 12.0 |
| 2-4 | 8 | 590.80 | 73.85 | 100.0% | 9.3 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |
| 16-24 | 4 | 159.10 | 39.78 | 100.0% | 7.0 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 72 | 4001.70 | 55.58 | 100.0% | 8.6 |
| 2-4 | 13 | 1195.70 | 91.98 | 100.0% | 24.9 |
| 4-6 | 8 | 573.00 | 71.63 | 100.0% | 10.9 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| >=12 | 4 | 197.80 | 49.45 | 100.0% | 20.0 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 37 | 3045.50 | 82.31 | 100.0% | 11.9 |
| <5 | 29 | 2011.80 | 69.37 | 100.0% | 1.2 |
| 15-30 | 28 | 873.50 | 31.20 | 100.0% | 20.3 |
| 60-180 | 7 | 264.00 | 37.71 | 100.0% | 90.2 |
| 30-60 | 6 | 185.50 | 30.92 | 100.0% | 36.7 |
| 180-720 | 1 | 450.00 | 450.00 | 100.0% | 198.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 108 | 6830.30 | 63.24 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 82 | 5149.90 | 62.80 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1310.20 | 65.51 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 82 | 5149.90 | 62.80 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1310.20 | 65.51 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 70 | 4128.20 | 58.97 | 10.9 | 16.6 | 248.54 | 0 |
| 2026-07 | 38 | 2702.10 | 71.11 | 16.0 | 19.6 | 137.96 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 37 | 1379.50 | 37.28 | 5.1 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1310.20 | 65.51 | 14.1 |
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
| 3.60 | 7 | 663.90 | 94.84 | 11.9 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 3 | 278.40 | 92.80 | 23.3 |
| 12.00 | 2 | 485.00 | 242.50 | 107.5 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 15.00 | 1 | 45.50 | 45.50 | 44.6 |
| 16.25 | 1 | 35.00 | 35.00 | 23.6 |
| 23.75 | 1 | 35.00 | 35.00 | 57.7 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 38.75 | 2 | 125.80 | 62.90 | 14.7 |
| 48.62 | 2 | 71.00 | 35.50 | 19.9 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |
| 62.50 | 1 | 34.00 | 34.00 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
