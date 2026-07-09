# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_015/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_015/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 96
- Entry signals: 96
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 7332
- Total paired trade PnL: 6148.60
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 19.1 minutes

## Lean Runtime Statistics
- Equity: $106,148.60
- Net Profit: $6,148.60
- Return: 6.15 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $40,402,657.60

## Risk And Efficiency
- Exposure hours: 30.6
- PnL per exposure hour: 200.72
- Calendar span days: 12.3
- PnL per calendar day: 499.18
- Trades per calendar day: 7.79
- Exposure share of calendar time: 10.4%
- Growth quality score: 10144.5
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 58
- Fast PnL per exposure hour: 702.49

## Pullback Broken Structure Veto
- Blocked signal rows: 1248
- Blocked by profile: `{"charm_pin_pullback_long": 1240, "pullback_long": 8}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 39, "charm_wall_breakaway_long": 5, "pullback_long": 14, "pullback_long_no_0dte": 3, "squeeze_long": 11}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1303.999999999991, "breakout_long_no_0dte": 278.40000000001237, "call_wall_acceptance_long": 91.0, "charm_pin_pullback_long": 1526.2000000001526, "charm_wall_breakaway_long": 973.0999999999876, "pullback_long": 1129.1000000001031, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 755.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=28.2933, sortinoRatio=0, alpha=0, beta=0, informationRatio=28.9721, drawdown=0.004
- Trades: sharpeRatio=0.9494, averageMAE=-95.5594, averageMFE=82.3745, largestMAE=-527.0, largestMFE=453.25, maximumIntraTradeDrawdown=-569.5

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 39 | 1526.20 | 39.13 | 100.0% | 6.7 | 8.5 | 178.81 | 0 | -527.00 | 42.50 | 2.40 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1304.00 | 65.20 | 100.0% | 14.1 | 7.7 | 168.63 | 0 | -375.70 | 79.88 | 3.00 |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 14 | 1129.10 | 80.65 | 100.0% | 11.1 | 2.7 | 417.58 | 0 | -138.25 | 102.10 | 3.32 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 973.10 | 194.62 | 100.0% | 16.0 | 4.1 | 234.69 | 0 | -346.80 | 146.20 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 11 | 755.00 | 68.64 | 100.0% | 17.3 | 4.2 | 179.20 | 0 | -208.25 | 66.30 | 28.44 |
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
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 39 | 62.36 | 29.30 | 50.11 | 20.52 | 13.1 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 14 | 50.62 | 7.06 | 51.59 | 13.92 | 11.6 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 75.96 | 21.06 | 57.99 | 17.35 | 49.8 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 11 | 68.99 | 10.57 | 67.57 | 21.40 | 23.0 | 0 |
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
- MAE: average -96.57, median -70.20, worst -527.00
- MFE: average 82.37, median 55.80, best 453.25
- Average MFE / absolute MAE: 0.85

## Intratrade Path
- Trades with path stats: 96; with intratrade price samples: 96
- Went positive before max adverse: 55.2%
- MFE happened before MAE: 10.4%
- TP touched before MAE: 1.0%
- Median MFE available before MAE: 0.20 points
- Median first TP touch: 4.2 minutes
- Median first +1.5 points: 3.0 minutes
- First 15m MFE/MAE medians: 2.40 / -1.97 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T12:36:10+00:00` -> `2026-06-26T13:56:26+00:00`.
- Strategy/profile: `charm_pin_pullback_long` / `charm_pin_pullback_long`. PnL 42.50, MAE -527.00, MFE 42.50, hold 80.3 minutes.
- Profile context: `charm_pin_pullback_long` produced 39 trades, PnL 1526.20, 0 slow >=12h trades, and 24.8% of total PnL.
- Entry state: setup=61.99, ES-VWAP=26.20, VWAP slope=0.0431, VWAP acceleration=-0.0150, RSI=42.42, ADX=17.95, structure score=4.00, higher-low=0.2500, higher-high=3.75, pullback-from-high=9.75, rolling-high distance=14.75.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=4.00, slow-risk points=0.00.
- Existing warning reason: ES pullback from high 9.75 >= 5.00; RSI slope -3.8597 <= -2.0000; ADX 17.95 <= 18.00; RSI 42.42 <= 45.00.
- Strategy selection reason: positive gamma/charm pin pullback: expectedMovePosition=0.0105, netCharm30m=-25173027, lowerFade=False, pullback=True, dynamicMaxVwapDistance=17.83.
- Intratrade path: path MFE 2.50, path MAE -28.50, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 62` would block this trade, keep 51 trades, retain 52.1% PnL, and leave worst MAE -375.70. It would block 45 trades total.
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
| `es_structure_rising_vwap != "False"` | 19 | 7 | 14 | 75 | 4636.00 | 1512.60 | 75.4% | -527.00 | 12772.5 |
| `long_strategy != "breakout_long_1dte"` | 19 | 6 | 14 | 76 | 4844.60 | 1304.00 | 78.8% | -527.00 | 12741.5 |
| `strategy_profile != "breakout_long_1dte"` | 19 | 6 | 14 | 76 | 4844.60 | 1304.00 | 78.8% | -527.00 | 12741.5 |
| `long_strategy != "charm_pin_pullback_long"` | 19 | 7 | 32 | 57 | 4622.40 | 1526.20 | 75.2% | -375.70 | 10848.9 |
| `strategy_profile != "charm_pin_pullback_long"` | 19 | 7 | 32 | 57 | 4622.40 | 1526.20 | 75.2% | -375.70 | 10848.9 |
| `path_half_tp_touch_minutes >= 0.183333` | 19 | 10 | 22 | 64 | 4516.80 | 1631.80 | 73.5% | -527.00 | 410.1 |
| `path_first_observed_points >= -0.55` | 19 | 6 | 9 | 81 | 5289.70 | 858.90 | 86.0% | -375.70 | 274.0 |
| `path_first_nonzero_move_points >= -0.55` | 19 | 6 | 9 | 81 | 5289.70 | 858.90 | 86.0% | -375.70 | 274.0 |
| `path_first_observed_points >= -0.65` | 19 | 5 | 9 | 82 | 5332.20 | 816.40 | 86.7% | -527.00 | 208.0 |
| `path_first_nonzero_move_points >= -0.65` | 19 | 5 | 9 | 82 | 5332.20 | 816.40 | 86.7% | -527.00 | 208.0 |
| `ema20 >= 7457.06` | 19 | 6 | 12 | 78 | 4914.40 | 1234.20 | 79.9% | -365.40 | 201.9 |
| `es_vwap >= 7454.42` | 19 | 6 | 12 | 78 | 4907.40 | 1241.20 | 79.8% | -365.40 | 200.7 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36947
- position_wait: 7332
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1344
- trade_risk_tighten_signal: 522
- order_event: 435
- waiting_spx_quote: 415
- entry_signal: 96

## Blocked Gate Counts
- setup_quality_allowed: 15043 (disabled=15043)
- above_vwap_confirmed: 9395 (disabled=9395)
- above_vwap: 8415 (disabled=8415)
- es_structure_allowed: 8414 (disabled=8414)
- pullback: 6661 (disabled=6661)
- momentum: 4491 (disabled=4491)
- es_vwap_slope_allowed: 4355 (disabled=4355)
- es_vwap_max_distance_allowed: 3958 (disabled=3958)
- trend_strength: 3375 (disabled=3375)
- es_vwap_acceleration_allowed: 2004 (disabled=2004)
- es_rolling_high_allowed: 511 (disabled=511)
- indicator_slope_allowed: 212 (disabled=212)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 14 | 10 | 813.40 | 81.34 | 100.0% | 2.1 |
| 13 | 9 | 440.40 | 48.93 | 100.0% | 0.4 |
| 8 | 8 | 1045.60 | 130.70 | 100.0% | 20.1 |
| 12 | 7 | 396.50 | 56.64 | 100.0% | 12.0 |
| 1 | 6 | 512.20 | 85.37 | 100.0% | 3.0 |
| 18 | 6 | 336.60 | 56.10 | 100.0% | 10.4 |
| 7 | 6 | 296.70 | 49.45 | 100.0% | 12.7 |
| 9 | 6 | 324.80 | 54.13 | 100.0% | 14.0 |
| 11 | 5 | 178.20 | 35.64 | 100.0% | 12.0 |
| 15 | 5 | 224.60 | 44.92 | 100.0% | 11.9 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 2 | 4 | 211.40 | 52.85 | 100.0% | 48.6 |
| 22 | 4 | 392.90 | 98.23 | 100.0% | 14.9 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 19 | 3 | 176.80 | 58.93 | 100.0% | 8.4 |
| 6 | 3 | 103.10 | 34.37 | 100.0% | 16.4 |
| 10 | 2 | 55.40 | 27.70 | 100.0% | 18.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 45 | 2415.20 | 53.67 | 100.0% | 7.2 |
| 55-60 | 18 | 1344.50 | 74.69 | 100.0% | 14.6 |
| >=75 | 11 | 1009.50 | 91.77 | 100.0% | 9.9 |
| 70-75 | 9 | 447.00 | 49.67 | 100.0% | 20.0 |
| 60-65 | 8 | 390.40 | 48.80 | 100.0% | 23.7 |
| 65-70 | 5 | 542.00 | 108.40 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 40 | 2619.70 | 65.49 | 100.0% | 11.0 |
| 20-25 | 19 | 1365.60 | 71.87 | 100.0% | 14.0 |
| 25-30 | 17 | 1068.00 | 62.82 | 100.0% | 12.0 |
| 30-40 | 15 | 793.50 | 52.90 | 100.0% | 12.0 |
| 40-50 | 5 | 301.80 | 60.36 | 100.0% | 12.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 96 | 6148.60 | 64.05 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 92 | 5567.10 | 60.51 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 49 | 3179.20 | 64.88 | 100.0% | 12.0 |
| -0.05-0 | 29 | 1540.80 | 53.13 | 100.0% | 8.7 |
| 0.1-0.25 | 9 | 1000.70 | 111.19 | 100.0% | 14.7 |
| 0.05-0.1 | 6 | 287.40 | 47.90 | 100.0% | 20.5 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 24 | 1375.90 | 57.33 | 100.0% | 13.6 |
| 4-6 | 23 | 893.90 | 38.87 | 100.0% | 2.3 |
| 0-1 | 20 | 1635.00 | 81.75 | 100.0% | 13.9 |
| 6-8 | 11 | 832.10 | 75.65 | 100.0% | 9.4 |
| 8-12 | 8 | 779.50 | 97.44 | 100.0% | 13.6 |
| 1-2 | 6 | 400.20 | 66.70 | 100.0% | 18.6 |
| 12-20 | 3 | 197.00 | 65.67 | 100.0% | 7.2 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 30 | 2048.80 | 68.29 | 100.0% | 9.8 |
| <1 | 24 | 1822.70 | 75.95 | 100.0% | 14.9 |
| 1-3 | 13 | 945.60 | 72.74 | 100.0% | 17.3 |
| 5-10 | 12 | 640.50 | 53.38 | 100.0% | 10.3 |
| 3-5 | 9 | 417.50 | 46.39 | 100.0% | 11.9 |
| 10-20 | 7 | 207.00 | 29.57 | 100.0% | 15.2 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 27 | 2146.30 | 79.49 | 100.0% | 12.0 |
| 0-1 | 20 | 966.50 | 48.33 | 100.0% | 10.7 |
| -1-0 | 11 | 787.20 | 71.56 | 100.0% | 12.0 |
| <-3 | 9 | 418.70 | 46.52 | 100.0% | 6.7 |
| -3--2 | 8 | 323.80 | 40.48 | 100.0% | 6.8 |
| -2--1 | 6 | 272.40 | 45.40 | 100.0% | 27.6 |
| 1-2 | 5 | 243.20 | 48.64 | 100.0% | 16.5 |
| 2-3 | 5 | 654.10 | 130.82 | 100.0% | 15.6 |
| missing | 5 | 336.40 | 67.28 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 34 | 2170.50 | 63.84 | 100.0% | 11.9 |
| -1-0 | 30 | 2170.60 | 72.35 | 100.0% | 14.6 |
| 1-2 | 18 | 1112.70 | 61.82 | 100.0% | 7.1 |
| -2--1 | 9 | 358.40 | 39.82 | 100.0% | 16.5 |
| missing | 5 | 336.40 | 67.28 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 26 | 1205.60 | 46.37 | 100.0% | 14.1 |
| 4-8 | 20 | 2198.50 | 109.92 | 100.0% | 10.9 |
| 1-2 | 19 | 978.00 | 51.47 | 100.0% | 9.7 |
| >=8 | 16 | 1111.00 | 69.44 | 100.0% | 15.3 |
| 0-0.5 | 9 | 340.20 | 37.80 | 100.0% | 1.9 |
| 0.5-1 | 6 | 315.30 | 52.55 | 100.0% | 14.0 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 38 | 2304.50 | 60.64 | 100.0% | 15.1 |
| 5 | 31 | 1924.20 | 62.07 | 100.0% | 11.9 |
| 3 | 25 | 1850.90 | 74.04 | 100.0% | 12.0 |
| 2 | 2 | 69.00 | 34.50 | 100.0% | 16.9 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 41 | 3218.60 | 78.50 | 100.0% | 14.0 |
| 2-4 | 29 | 1591.40 | 54.88 | 100.0% | 11.9 |
| 4-8 | 21 | 1115.10 | 53.10 | 100.0% | 9.4 |
| 8-12 | 5 | 223.50 | 44.70 | 100.0% | 17.3 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 32 | 2134.80 | 66.71 | 100.0% | 13.1 |
| 2-4 | 17 | 744.50 | 43.79 | 100.0% | 16.1 |
| 1-2 | 11 | 782.60 | 71.15 | 100.0% | 13.2 |
| 4-8 | 11 | 561.00 | 51.00 | 100.0% | 9.9 |
| 0.5-1 | 9 | 720.80 | 80.09 | 100.0% | 2.4 |
| >=8 | 9 | 717.50 | 79.72 | 100.0% | 12.0 |
| 0-0.5 | 7 | 487.40 | 69.63 | 100.0% | 12.0 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 27 | 1671.50 | 61.91 | 100.0% | 9.7 |
| 2-4 | 18 | 1249.20 | 69.40 | 100.0% | 10.6 |
| 1-2 | 16 | 1041.50 | 65.09 | 100.0% | 16.0 |
| 4-8 | 15 | 1095.40 | 73.03 | 100.0% | 12.0 |
| >=8 | 9 | 559.00 | 62.11 | 100.0% | 14.7 |
| 0-0.5 | 6 | 245.10 | 40.85 | 100.0% | 19.0 |
| 0.5-1 | 5 | 286.90 | 57.38 | 100.0% | 12.0 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 31 | 2209.20 | 71.26 | 100.0% | 14.7 |
| >=24 | 30 | 1048.90 | 34.96 | 100.0% | 3.8 |
| 8-12 | 11 | 1103.90 | 100.35 | 100.0% | 25.7 |
| 12-16 | 7 | 425.10 | 60.73 | 100.0% | 12.0 |
| 2-4 | 7 | 523.30 | 74.76 | 100.0% | 9.8 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 4 | 175.90 | 43.98 | 100.0% | 12.6 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 28 | 1860.10 | 66.43 | 100.0% | 9.9 |
| 60-70 | 25 | 1370.30 | 54.81 | 100.0% | 12.0 |
| 70-80 | 20 | 1549.50 | 77.48 | 100.0% | 12.0 |
| 40-50 | 12 | 818.60 | 68.22 | 100.0% | 13.5 |
| 80-90 | 11 | 550.10 | 50.01 | 100.0% | 16.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 24 | 1793.60 | 74.73 | 100.0% | 12.1 |
| 2-3 | 23 | 992.40 | 43.15 | 100.0% | 15.6 |
| 3-4 | 17 | 789.20 | 46.42 | 100.0% | 12.0 |
| 4-5 | 15 | 1464.50 | 97.63 | 100.0% | 9.4 |
| 5-6 | 9 | 402.70 | 44.74 | 100.0% | 7.2 |
| <1 | 8 | 706.20 | 88.28 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 96 | 6148.60 | 64.05 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 96 | 6148.60 | 64.05 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 31 | 2209.20 | 71.26 | 100.0% | 14.7 |
| >=24 | 30 | 1048.90 | 34.96 | 100.0% | 3.8 |
| 8-12 | 11 | 1103.90 | 100.35 | 100.0% | 25.7 |
| 12-16 | 7 | 425.10 | 60.73 | 100.0% | 12.0 |
| 2-4 | 7 | 523.30 | 74.76 | 100.0% | 9.8 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 4 | 175.90 | 43.98 | 100.0% | 12.6 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 58 | 3202.10 | 55.21 | 100.0% | 9.6 |
| 2-4 | 13 | 1179.10 | 90.70 | 100.0% | 24.9 |
| 4-6 | 8 | 583.50 | 72.94 | 100.0% | 10.9 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| >=12 | 5 | 230.80 | 46.16 | 100.0% | 16.6 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |
| 0-1 | 1 | 91.00 | 91.00 | 100.0% | 12.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 35 | 3092.60 | 88.36 | 100.0% | 11.9 |
| 15-30 | 26 | 811.90 | 31.23 | 100.0% | 19.5 |
| <5 | 23 | 1429.10 | 62.13 | 100.0% | 0.9 |
| 30-60 | 6 | 185.50 | 30.92 | 100.0% | 36.7 |
| 60-180 | 5 | 192.00 | 38.40 | 100.0% | 81.9 |
| 180-720 | 1 | 437.50 | 437.50 | 100.0% | 194.8 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 96 | 6148.60 | 64.05 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 70 | 4474.40 | 63.92 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1304.00 | 65.20 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 70 | 4474.40 | 63.92 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1304.00 | 65.20 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 65 | 3935.50 | 60.55 | 12.0 | 16.1 | 244.28 | 0 |
| 2026-07 | 31 | 2213.10 | 71.39 | 15.6 | 14.5 | 152.39 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.20 | 1 | 91.00 | 91.00 | 9.8 |
| 2.28 | 1 | 45.50 | 45.50 | 12.0 |
| 2.40 | 37 | 1389.70 | 37.56 | 5.5 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.50 | 1 | 35.00 | 35.00 | 13.2 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 3.00 | 20 | 1304.00 | 65.20 | 14.1 |
| 3.02 | 1 | 111.60 | 111.60 | 9.7 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.13 | 1 | 112.00 | 112.00 | 5.3 |
| 3.30 | 1 | 118.80 | 118.80 | 0.1 |
| 3.35 | 1 | 119.00 | 119.00 | 8.4 |
| 3.46 | 1 | 136.50 | 136.50 | 8.8 |
| 3.47 | 1 | 144.00 | 144.00 | 10.2 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.60 | 1 | 66.50 | 66.50 | 12.0 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 3 | 278.40 | 92.80 | 23.3 |
| 12.00 | 5 | 973.10 | 194.62 | 16.0 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 15.00 | 1 | 45.50 | 45.50 | 44.6 |
| 16.25 | 1 | 35.00 | 35.00 | 23.6 |
| 21.56 | 1 | 35.00 | 35.00 | 21.6 |
| 23.75 | 1 | 35.00 | 35.00 | 57.7 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 28.66 | 1 | 91.00 | 91.00 | 12.0 |
| 38.75 | 2 | 125.80 | 62.90 | 14.7 |
| 48.62 | 2 | 70.00 | 35.00 | 19.9 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
