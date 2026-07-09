# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_009/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_009/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 98
- Entry signals: 98
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8239
- Total paired trade PnL: 6379.40
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 21.8 minutes

## Lean Runtime Statistics
- Equity: $106,379.40
- Net Profit: $6,379.40
- Return: 6.38 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $41,663,364.80

## Risk And Efficiency
- Exposure hours: 35.6
- PnL per exposure hour: 179.30
- Calendar span days: 12.3
- PnL per calendar day: 517.91
- Trades per calendar day: 7.96
- Exposure share of calendar time: 12.0%
- Growth quality score: 10287.7
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 59
- Fast PnL per exposure hour: 820.76

## Pullback Broken Structure Veto
- Blocked signal rows: 1216
- Blocked by profile: `{"charm_pin_pullback_long": 1164, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "charm_pin_pullback_long": 34, "charm_wall_breakaway_long": 7, "pullback_long": 31, "pullback_long_no_0dte": 3}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1298.6999999999907, "breakout_long_no_0dte": 277.40000000001237, "charm_pin_pullback_long": 1237.7000000001144, "charm_wall_breakaway_long": 1060.5999999999876, "pullback_long": 2413.2000000002363, "pullback_long_no_0dte": 91.79999999999018}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=30.1201, sortinoRatio=0, alpha=0, beta=0, informationRatio=30.7648, drawdown=0.005
- Trades: sharpeRatio=1.0035, averageMAE=-105.0689, averageMFE=82.2403, largestMAE=-638.75, largestMFE=449.75, maximumIntraTradeDrawdown=-682.50

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 2413.20 | 77.85 | 100.0% | 12.0 | 12.5 | 192.96 | 0 | -638.75 | 106.20 | 3.35 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1298.70 | 64.93 | 100.0% | 14.1 | 7.7 | 167.94 | 0 | -375.70 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 1237.70 | 36.40 | 100.0% | 5.3 | 7.5 | 164.67 | 0 | -527.00 | 42.50 | 2.40 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 7 | 1060.60 | 151.51 | 100.0% | 15.3 | 4.7 | 224.54 | 0 | -346.80 | 83.30 | 12.00 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 | 0.2 | 845.57 | 0 | -76.50 | 243.10 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 91.80 | 30.60 | 100.0% | 16.4 | 1.1 | 83.22 | 0 | -103.50 | 27.90 | 4.00 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 70.00 | 35.00 | 100.0% | 52.6 | 1.8 | 39.94 | 0 | -243.10 | 61.55 | 6.00 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 50.03 | 6.71 | 49.20 | 21.81 | 24.2 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 66.16 | 29.56 | 49.07 | 19.65 | 13.3 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 7 | 71.26 | 18.08 | 59.29 | 18.43 | 40.5 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 70.88 | 7.38 | 81.57 | 27.17 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 54.55 | 5.48 | 48.15 | 19.52 | 22.1 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 78.32 | 11.24 | 80.45 | 28.97 | 52.6 | 0 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
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
- MAE: average -106.15, median -69.70, worst -638.75
- MFE: average 82.24, median 55.80, best 449.75
- Average MFE / absolute MAE: 0.77

## Intratrade Path
- Trades with path stats: 98; with intratrade price samples: 98
- Went positive before max adverse: 50.0%
- MFE happened before MAE: 10.2%
- TP touched before MAE: 1.0%
- Median MFE available before MAE: 0.03 points
- Median first TP touch: 3.9 minutes
- Median first +1.5 points: 2.8 minutes
- First 15m MFE/MAE medians: 2.40 / -2.00 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-07-01T06:48:37+00:00` -> `2026-07-01T09:56:31+00:00`.
- Strategy/profile: `pullback_long` / `pullback_long`. PnL 35.00, MAE -638.75, MFE 43.75, hold 187.9 minutes.
- Profile context: `pullback_long` produced 31 trades, PnL 2413.20, 0 slow >=12h trades, and 37.8% of total PnL.
- Entry state: setup=58.84, ES-VWAP=7.84, VWAP slope=0.0164, VWAP acceleration=-0.0021, RSI=55.24, ADX=29.83, structure score=3.00, higher-low=-2.00, higher-high=-1.25, pullback-from-high=1.25, rolling-high distance=3.75.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=3.00, slow-risk points=0.00.
- Existing warning reason: ES structure score 3 <= 3; ES structure higher-low -2.00 < 0.25; ES structure higher-high -1.25 < 0.00.
- Strategy selection reason: VALID_0DTE ordered router; ordered ES pullback: trendPrice=7535.00, ema=7535.18, distance=7.84, adx=29.83, rsi=55.24, structure=3.
- Intratrade path: path MFE 1.25, path MAE -17.75, MFE before MAE=`False`, TP reached=`False`.
- Surgical setup floor check: `setup_quality_score >= 58.9` would block this trade, keep 51 trades, retain 47.9% PnL, and leave worst MAE -527.00. It would block 47 trades total.
- No single candidate threshold in the report cleanly removes this tail; the closest visible guard is setup quality 58.84.

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
| `es_structure_rising_vwap != "False"` | 19 | 5 | 7 | 86 | 5546.80 | 832.60 | 86.9% | -638.75 | 15487.0 |
| `long_strategy != "breakout_long_1dte"` | 19 | 6 | 14 | 78 | 5080.70 | 1298.70 | 79.6% | -638.75 | 15426.6 |
| `strategy_profile != "breakout_long_1dte"` | 19 | 6 | 14 | 78 | 5080.70 | 1298.70 | 79.6% | -638.75 | 15426.6 |
| `path_half_tp_touch_minutes >= 0.183333` | 19 | 12 | 16 | 70 | 5293.60 | 1085.80 | 83.0% | -527.00 | 664.8 |
| `es_structure_pullback_from_high <= 3.75` | 19 | 7 | 22 | 69 | 4600.70 | 1778.70 | 72.1% | -638.75 | 162.6 |
| `path_first_observed_points >= -0.25` | 19 | 7 | 28 | 63 | 4553.60 | 1825.80 | 71.4% | -638.75 | 145.1 |
| `path_first_nonzero_move_points >= -0.25` | 19 | 7 | 28 | 63 | 4553.60 | 1825.80 | 71.4% | -638.75 | 145.1 |
| `adx14 <= 28.4603` | 19 | 6 | 21 | 71 | 4821.00 | 1558.40 | 75.6% | -527.00 | 130.1 |
| `path_first_observed_points >= -0.55` | 19 | 4 | 11 | 83 | 5461.00 | 918.40 | 85.6% | -638.75 | 112.9 |
| `path_first_nonzero_move_points >= -0.55` | 19 | 4 | 11 | 83 | 5461.00 | 918.40 | 85.6% | -638.75 | 112.9 |
| `path_first_observed_points >= -0.35` | 19 | 6 | 27 | 65 | 4704.60 | 1674.80 | 73.7% | -638.75 | 100.1 |
| `path_first_nonzero_move_points >= -0.35` | 19 | 6 | 27 | 65 | 4704.60 | 1674.80 | 73.7% | -638.75 | 100.1 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36040
- position_wait: 8239
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- order_event: 439
- trade_risk_tighten_signal: 428
- waiting_spx_quote: 415
- entry_signal: 98

## Blocked Gate Counts
- setup_quality_allowed: 14400 (disabled=14400)
- above_vwap_confirmed: 8934 (disabled=8934)
- above_vwap: 7998 (disabled=7998)
- es_structure_allowed: 7755 (disabled=7755)
- pullback: 6668 (disabled=6668)
- momentum: 4124 (disabled=4124)
- es_vwap_max_distance_allowed: 3915 (disabled=3915)
- es_vwap_slope_allowed: 3738 (disabled=3738)
- trend_strength: 3308 (disabled=3308)
- es_vwap_acceleration_allowed: 1928 (disabled=1928)
- es_rolling_high_allowed: 509 (disabled=509)
- indicator_slope_allowed: 179 (disabled=179)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 728.40 | 60.70 | 100.0% | 0.4 |
| 14 | 10 | 851.90 | 85.19 | 100.0% | 2.1 |
| 12 | 7 | 262.30 | 37.47 | 100.0% | 12.2 |
| 8 | 7 | 868.10 | 124.01 | 100.0% | 16.6 |
| 1 | 6 | 512.20 | 85.37 | 100.0% | 3.0 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 18 | 6 | 337.60 | 56.27 | 100.0% | 10.4 |
| 11 | 5 | 178.20 | 35.64 | 100.0% | 12.0 |
| 19 | 5 | 250.30 | 50.06 | 100.0% | 17.0 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 232.60 | 46.52 | 100.0% | 16.4 |
| 2 | 4 | 210.40 | 52.60 | 100.0% | 48.6 |
| 22 | 4 | 392.90 | 98.23 | 100.0% | 14.9 |
| 9 | 4 | 198.00 | 49.50 | 100.0% | 11.9 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 10 | 2 | 65.90 | 32.95 | 100.0% | 21.3 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 146.20 | 73.10 | 100.0% | 15.9 |
| 7 | 2 | 167.80 | 83.90 | 100.0% | 7.8 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 56 | 3329.30 | 59.45 | 100.0% | 7.2 |
| 55-60 | 16 | 1043.90 | 65.24 | 100.0% | 18.8 |
| >=75 | 11 | 1009.50 | 91.77 | 100.0% | 9.9 |
| 60-65 | 6 | 309.70 | 51.62 | 100.0% | 18.9 |
| 65-70 | 5 | 550.00 | 110.00 | 100.0% | 16.4 |
| 70-75 | 4 | 137.00 | 34.25 | 100.0% | 21.6 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 40 | 2474.60 | 61.87 | 100.0% | 8.6 |
| 20-25 | 18 | 1532.40 | 85.13 | 100.0% | 9.6 |
| 25-30 | 18 | 1047.20 | 58.18 | 100.0% | 13.4 |
| 30-40 | 16 | 950.10 | 59.38 | 100.0% | 12.0 |
| 40-50 | 5 | 336.60 | 67.32 | 100.0% | 4.8 |
| >=50 | 1 | 38.50 | 38.50 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 98 | 6379.40 | 65.10 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 94 | 5797.90 | 61.68 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 47 | 2753.70 | 58.59 | 100.0% | 12.1 |
| -0.05-0 | 37 | 2393.10 | 64.68 | 100.0% | 7.3 |
| 0.1-0.25 | 7 | 874.90 | 124.99 | 100.0% | 16.6 |
| 0.05-0.1 | 4 | 217.20 | 54.30 | 100.0% | 20.0 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 27 | 1336.00 | 49.48 | 100.0% | 5.8 |
| 2-4 | 23 | 1191.60 | 51.81 | 100.0% | 15.3 |
| 0-1 | 18 | 1341.40 | 74.52 | 100.0% | 12.6 |
| 6-8 | 13 | 1384.60 | 106.51 | 100.0% | 9.4 |
| 8-12 | 6 | 361.80 | 60.30 | 100.0% | 9.3 |
| 1-2 | 5 | 287.00 | 57.40 | 100.0% | 20.6 |
| 12-20 | 5 | 442.00 | 88.40 | 100.0% | 6.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 31 | 2247.80 | 72.51 | 100.0% | 7.2 |
| <1 | 21 | 1416.90 | 67.47 | 100.0% | 14.7 |
| 10-20 | 14 | 725.30 | 51.81 | 100.0% | 14.0 |
| 5-10 | 12 | 640.50 | 53.38 | 100.0% | 10.3 |
| 3-5 | 10 | 543.30 | 54.33 | 100.0% | 10.2 |
| 1-3 | 9 | 739.10 | 82.12 | 100.0% | 20.6 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 29 | 2269.30 | 78.25 | 100.0% | 13.2 |
| 0-1 | 19 | 942.20 | 49.59 | 100.0% | 6.6 |
| <-3 | 10 | 544.50 | 54.45 | 100.0% | 5.8 |
| -3--2 | 8 | 323.80 | 40.48 | 100.0% | 6.8 |
| -1-0 | 7 | 310.70 | 44.39 | 100.0% | 7.2 |
| -2--1 | 7 | 478.90 | 68.41 | 100.0% | 12.0 |
| 1-2 | 6 | 379.50 | 63.25 | 100.0% | 13.5 |
| 2-3 | 6 | 689.10 | 114.85 | 100.0% | 17.8 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 37 | 2601.00 | 70.30 | 100.0% | 9.9 |
| -1-0 | 30 | 1995.60 | 66.52 | 100.0% | 15.3 |
| 1-2 | 17 | 1084.50 | 63.79 | 100.0% | 5.8 |
| -2--1 | 8 | 256.90 | 32.11 | 100.0% | 30.0 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 32 | 1680.70 | 52.52 | 100.0% | 15.1 |
| 4-8 | 22 | 2243.70 | 101.99 | 100.0% | 12.0 |
| 1-2 | 20 | 1133.00 | 56.65 | 100.0% | 7.8 |
| 0-0.5 | 10 | 466.20 | 46.62 | 100.0% | 4.5 |
| 0.5-1 | 7 | 420.30 | 60.04 | 100.0% | 11.9 |
| >=8 | 7 | 435.50 | 62.21 | 100.0% | 15.3 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 37 | 2169.30 | 58.63 | 100.0% | 12.0 |
| 3 | 31 | 2433.20 | 78.49 | 100.0% | 9.4 |
| 5 | 30 | 1776.90 | 59.23 | 100.0% | 11.9 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 42 | 3103.80 | 73.90 | 100.0% | 13.9 |
| 2-4 | 27 | 1496.90 | 55.44 | 100.0% | 11.9 |
| 4-8 | 24 | 1463.40 | 60.98 | 100.0% | 8.5 |
| 8-12 | 5 | 315.30 | 63.06 | 100.0% | 6.7 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 35 | 2532.60 | 72.36 | 100.0% | 12.7 |
| 2-4 | 16 | 588.80 | 36.80 | 100.0% | 18.1 |
| 4-8 | 13 | 648.50 | 49.88 | 100.0% | 12.0 |
| 0.5-1 | 11 | 959.20 | 87.20 | 100.0% | 3.8 |
| 1-2 | 11 | 852.60 | 77.51 | 100.0% | 12.0 |
| 0-0.5 | 7 | 490.90 | 70.13 | 100.0% | 12.0 |
| >=8 | 5 | 306.80 | 61.36 | 100.0% | 8.4 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 38 | 2601.80 | 68.47 | 100.0% | 8.6 |
| 2-4 | 18 | 1257.20 | 69.84 | 100.0% | 10.6 |
| 1-2 | 14 | 848.90 | 60.64 | 100.0% | 16.0 |
| 4-8 | 12 | 720.50 | 60.04 | 100.0% | 11.0 |
| >=8 | 7 | 489.00 | 69.86 | 100.0% | 14.7 |
| 0-0.5 | 6 | 245.10 | 40.85 | 100.0% | 19.0 |
| 0.5-1 | 3 | 216.90 | 72.30 | 100.0% | 8.8 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2652.90 | 69.81 | 100.0% | 13.9 |
| >=24 | 30 | 1048.90 | 34.96 | 100.0% | 3.8 |
| 8-12 | 10 | 1193.50 | 119.35 | 100.0% | 15.2 |
| 2-4 | 7 | 531.30 | 75.90 | 100.0% | 6.5 |
| 16-24 | 6 | 616.80 | 102.80 | 100.0% | 12.3 |
| 12-16 | 4 | 195.10 | 48.77 | 100.0% | 12.0 |
| 0-2 | 3 | 140.90 | 46.97 | 100.0% | 12.0 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 33 | 2270.50 | 68.80 | 100.0% | 8.4 |
| 60-70 | 20 | 1047.10 | 52.36 | 100.0% | 10.9 |
| 40-50 | 17 | 1239.90 | 72.94 | 100.0% | 12.7 |
| 70-80 | 17 | 1340.70 | 78.86 | 100.0% | 12.0 |
| 80-90 | 11 | 481.20 | 43.75 | 100.0% | 19.8 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3-4 | 23 | 1460.00 | 63.48 | 100.0% | 8.7 |
| 1-2 | 21 | 1454.10 | 69.24 | 100.0% | 13.2 |
| 2-3 | 20 | 888.40 | 44.42 | 100.0% | 13.8 |
| 5-6 | 14 | 790.00 | 56.43 | 100.0% | 7.2 |
| 4-5 | 12 | 1315.00 | 109.58 | 100.0% | 7.5 |
| <1 | 8 | 471.90 | 58.99 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 98 | 6379.40 | 65.10 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 98 | 6379.40 | 65.10 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2652.90 | 69.81 | 100.0% | 13.9 |
| >=24 | 30 | 1048.90 | 34.96 | 100.0% | 3.8 |
| 8-12 | 10 | 1193.50 | 119.35 | 100.0% | 15.2 |
| 2-4 | 7 | 531.30 | 75.90 | 100.0% | 6.5 |
| 16-24 | 6 | 616.80 | 102.80 | 100.0% | 12.3 |
| 12-16 | 4 | 195.10 | 48.77 | 100.0% | 12.0 |
| 0-2 | 3 | 140.90 | 46.97 | 100.0% | 12.0 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 69 | 4162.70 | 60.33 | 100.0% | 8.7 |
| 2-4 | 11 | 1104.80 | 100.44 | 100.0% | 19.8 |
| 4-6 | 9 | 624.50 | 69.39 | 100.0% | 12.0 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| >=12 | 3 | 104.00 | 34.67 | 100.0% | 23.3 |
| 8-12 | 2 | 241.40 | 120.70 | 100.0% | 15.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 32 | 2793.90 | 87.31 | 100.0% | 9.1 |
| <5 | 27 | 1919.30 | 71.09 | 100.0% | 1.2 |
| 15-30 | 26 | 825.70 | 31.76 | 100.0% | 19.4 |
| 60-180 | 7 | 263.00 | 37.57 | 100.0% | 90.2 |
| 30-60 | 4 | 105.00 | 26.25 | 100.0% | 34.6 |
| 180-720 | 2 | 472.50 | 236.25 | 100.0% | 193.1 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 98 | 6379.40 | 65.10 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 72 | 4711.50 | 65.44 | 100.0% | 9.1 |
| VALID_1DTE_ONLY | 20 | 1298.70 | 64.93 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 161.80 | 32.36 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 72 | 4711.50 | 65.44 | 100.0% | 9.1 |
| VALID_1DTE_ONLY | 20 | 1298.70 | 64.93 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 161.80 | 32.36 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 64 | 3888.00 | 60.75 | 8.8 | 15.5 | 250.71 | 0 |
| 2026-07 | 34 | 2491.40 | 73.28 | 14.4 | 20.1 | 124.12 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.40 | 34 | 1237.70 | 36.40 | 5.3 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1298.70 | 64.93 | 14.1 |
| 3.02 | 2 | 147.60 | 73.80 | 49.9 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.14 | 1 | 108.50 | 108.50 | 6.5 |
| 3.19 | 1 | 35.00 | 35.00 | 26.0 |
| 3.22 | 1 | 115.50 | 115.50 | 6.6 |
| 3.26 | 1 | 115.50 | 115.50 | 3.8 |
| 3.30 | 1 | 118.80 | 118.80 | 0.1 |
| 3.31 | 2 | 69.00 | 34.50 | 17.2 |
| 3.33 | 1 | 36.00 | 36.00 | 29.9 |
| 3.34 | 1 | 35.00 | 35.00 | 155.4 |
| 3.35 | 1 | 119.00 | 119.00 | 8.4 |
| 3.43 | 1 | 46.80 | 46.80 | 12.7 |
| 3.44 | 1 | 119.00 | 119.00 | 7.3 |
| 3.46 | 1 | 136.50 | 136.50 | 8.8 |
| 3.48 | 1 | 122.50 | 122.50 | 5.8 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.60 | 8 | 697.80 | 87.23 | 9.5 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 3 | 277.40 | 92.47 | 23.3 |
| 12.00 | 7 | 1060.60 | 151.51 | 15.3 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
