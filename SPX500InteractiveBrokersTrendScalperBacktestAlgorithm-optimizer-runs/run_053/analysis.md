# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_053/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_053/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 95
- Entry signals: 95
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 7999
- Total paired trade PnL: 6301.90
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 21.8 minutes

## Lean Runtime Statistics
- Equity: $106,301.90
- Net Profit: $6,301.90
- Return: 6.30 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $40,892,545.30

## Risk And Efficiency
- Exposure hours: 34.6
- PnL per exposure hour: 182.25
- Calendar span days: 12.3
- PnL per calendar day: 511.62
- Trades per calendar day: 7.71
- Exposure share of calendar time: 11.7%
- Growth quality score: 10197.8
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 58
- Fast PnL per exposure hour: 830.22

## Pullback Broken Structure Veto
- Blocked signal rows: 1234
- Blocked by profile: `{"charm_pin_pullback_long": 1182, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "charm_pin_pullback_long": 31, "charm_wall_breakaway_long": 7, "pullback_long": 31, "pullback_long_no_0dte": 3}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1298.6999999999907, "breakout_long_no_0dte": 277.40000000001237, "charm_pin_pullback_long": 1160.2000000001144, "charm_wall_breakaway_long": 1060.5999999999876, "pullback_long": 2413.2000000002363, "pullback_long_no_0dte": 91.79999999999018}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=29.7241, sortinoRatio=0, alpha=0, beta=0, informationRatio=30.3743, drawdown=0.005
- Trades: sharpeRatio=1.0131, averageMAE=-105.1321, averageMFE=83.5868, largestMAE=-638.75, largestMFE=449.75, maximumIntraTradeDrawdown=-682.50

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 2413.20 | 77.85 | 100.0% | 12.0 | 12.5 | 192.96 | 0 | -638.75 | 106.20 | 3.35 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1298.70 | 64.93 | 100.0% | 14.1 | 7.7 | 167.94 | 0 | -375.70 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 1160.20 | 37.43 | 100.0% | 3.0 | 6.5 | 178.07 | 0 | -518.50 | 42.50 | 2.40 |
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
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 66.79 | 29.61 | 48.91 | 20.35 | 12.6 | 0 |
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
- MAE: average -106.25, median -69.28, worst -638.75
- MFE: average 83.59, median 56.10, best 449.75
- Average MFE / absolute MAE: 0.79

## Intratrade Path
- Trades with path stats: 95; with intratrade price samples: 95
- Went positive before max adverse: 50.5%
- MFE happened before MAE: 10.5%
- TP touched before MAE: 1.1%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 3.2 minutes
- Median first +1.5 points: 2.6 minutes
- First 15m MFE/MAE medians: 2.40 / -1.95 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-07-01T06:48:37+00:00` -> `2026-07-01T09:56:31+00:00`.
- Strategy/profile: `pullback_long` / `pullback_long`. PnL 35.00, MAE -638.75, MFE 43.75, hold 187.9 minutes.
- Profile context: `pullback_long` produced 31 trades, PnL 2413.20, 0 slow >=12h trades, and 38.3% of total PnL.
- Entry state: setup=58.84, ES-VWAP=7.84, VWAP slope=0.0164, VWAP acceleration=-0.0021, RSI=55.24, ADX=29.83, structure score=3.00, higher-low=-2.00, higher-high=-1.25, pullback-from-high=1.25, rolling-high distance=3.75.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=3.00, slow-risk points=0.00.
- Existing warning reason: ES structure score 3 <= 3; ES structure higher-low -2.00 < 0.25; ES structure higher-high -1.25 < 0.00.
- Strategy selection reason: VALID_0DTE ordered router; ordered ES pullback: trendPrice=7535.00, ema=7535.18, distance=7.84, adx=29.83, rsi=55.24, structure=3.
- Intratrade path: path MFE 1.25, path MAE -17.75, MFE before MAE=`False`, TP reached=`False`.
- Surgical setup floor check: `setup_quality_score >= 58.9` would block this trade, keep 49 trades, retain 47.5% PnL, and leave worst MAE -518.50. It would block 46 trades total.
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
| `es_structure_rising_vwap != "False"` | 18 | 5 | 7 | 83 | 5469.30 | 832.60 | 86.8% | -638.75 | 15506.5 |
| `long_strategy != "breakout_long_1dte"` | 18 | 6 | 14 | 75 | 5003.20 | 1298.70 | 79.4% | -638.75 | 15449.1 |
| `strategy_profile != "breakout_long_1dte"` | 18 | 6 | 14 | 75 | 5003.20 | 1298.70 | 79.4% | -638.75 | 15449.1 |
| `path_half_tp_touch_minutes >= 0.183333` | 18 | 11 | 17 | 67 | 5216.10 | 1085.80 | 82.8% | -518.50 | 634.6 |
| `es_structure_pullback_from_high <= 3.25` | 18 | 7 | 23 | 65 | 4455.20 | 1846.70 | 70.7% | -638.75 | 177.5 |
| `path_first_observed_seconds <= 9` | 18 | 6 | 23 | 66 | 4699.00 | 1602.90 | 74.6% | -638.75 | 143.6 |
| `path_first_nonzero_move_seconds <= 9` | 18 | 6 | 24 | 65 | 4658.20 | 1643.70 | 73.9% | -638.75 | 134.8 |
| `es_structure_pullback_from_high <= 3.75` | 18 | 6 | 20 | 69 | 4599.70 | 1702.20 | 73.0% | -638.75 | 130.3 |
| `path_first_observed_points >= -0.25` | 18 | 6 | 26 | 63 | 4550.90 | 1751.00 | 72.2% | -638.75 | 112.5 |
| `path_first_nonzero_move_points >= -0.25` | 18 | 6 | 26 | 63 | 4550.90 | 1751.00 | 72.2% | -638.75 | 112.5 |
| `es_structure_score <= 4` | 18 | 6 | 24 | 65 | 4525.00 | 1776.90 | 71.8% | -638.75 | 110.8 |
| `es_structure_pullback_from_high <= 4` | 18 | 5 | 18 | 72 | 4716.30 | 1585.60 | 74.8% | -638.75 | 76.5 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36280
- position_wait: 7999
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 426
- order_event: 425
- waiting_spx_quote: 415
- entry_signal: 95

## Blocked Gate Counts
- setup_quality_allowed: 14402 (disabled=14402)
- above_vwap_confirmed: 8934 (disabled=8934)
- above_vwap: 7998 (disabled=7998)
- es_structure_allowed: 7799 (disabled=7799)
- pullback: 6768 (disabled=6768)
- momentum: 4200 (disabled=4200)
- es_vwap_max_distance_allowed: 4059 (disabled=4059)
- es_vwap_slope_allowed: 3764 (disabled=3764)
- trend_strength: 3383 (disabled=3383)
- es_vwap_acceleration_allowed: 1949 (disabled=1949)
- es_rolling_high_allowed: 531 (disabled=531)
- indicator_slope_allowed: 185 (disabled=185)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 728.40 | 60.70 | 100.0% | 0.4 |
| 14 | 10 | 851.90 | 85.19 | 100.0% | 2.1 |
| 8 | 7 | 868.10 | 124.01 | 100.0% | 16.6 |
| 1 | 6 | 512.20 | 85.37 | 100.0% | 3.0 |
| 12 | 6 | 219.80 | 36.63 | 100.0% | 12.4 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 18 | 5 | 295.80 | 59.16 | 100.0% | 12.0 |
| 19 | 5 | 274.10 | 54.82 | 100.0% | 8.4 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 232.60 | 46.52 | 100.0% | 16.4 |
| 11 | 4 | 161.20 | 40.30 | 100.0% | 11.9 |
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
| <55 | 53 | 3228.00 | 60.91 | 100.0% | 7.2 |
| 55-60 | 16 | 1067.70 | 66.73 | 100.0% | 17.5 |
| >=75 | 11 | 1009.50 | 91.77 | 100.0% | 9.9 |
| 60-65 | 6 | 309.70 | 51.62 | 100.0% | 18.9 |
| 65-70 | 5 | 550.00 | 110.00 | 100.0% | 16.4 |
| 70-75 | 4 | 137.00 | 34.25 | 100.0% | 21.6 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 38 | 2416.80 | 63.60 | 100.0% | 8.6 |
| 25-30 | 18 | 1046.20 | 58.12 | 100.0% | 13.4 |
| 20-25 | 17 | 1515.40 | 89.14 | 100.0% | 9.4 |
| 30-40 | 17 | 990.90 | 58.29 | 100.0% | 12.0 |
| 40-50 | 4 | 294.10 | 73.53 | 100.0% | 13.2 |
| >=50 | 1 | 38.50 | 38.50 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 95 | 6301.90 | 66.34 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 91 | 5720.40 | 62.86 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 46 | 2736.70 | 59.49 | 100.0% | 12.1 |
| -0.05-0 | 35 | 2332.60 | 66.65 | 100.0% | 7.3 |
| 0.1-0.25 | 7 | 874.90 | 124.99 | 100.0% | 16.6 |
| 0.05-0.1 | 4 | 217.20 | 54.30 | 100.0% | 20.0 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 25 | 1301.00 | 52.04 | 100.0% | 2.3 |
| 2-4 | 22 | 1150.80 | 52.31 | 100.0% | 15.4 |
| 0-1 | 18 | 1341.40 | 74.52 | 100.0% | 12.6 |
| 6-8 | 12 | 1342.10 | 111.84 | 100.0% | 13.2 |
| 12-20 | 6 | 482.80 | 80.47 | 100.0% | 5.2 |
| 8-12 | 6 | 361.80 | 60.30 | 100.0% | 9.3 |
| 1-2 | 5 | 287.00 | 57.40 | 100.0% | 20.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 31 | 2246.80 | 72.48 | 100.0% | 7.2 |
| <1 | 21 | 1416.90 | 67.47 | 100.0% | 14.7 |
| 10-20 | 14 | 725.30 | 51.81 | 100.0% | 14.0 |
| 3-5 | 10 | 543.30 | 54.33 | 100.0% | 10.2 |
| 5-10 | 10 | 606.50 | 60.65 | 100.0% | 8.6 |
| 1-3 | 8 | 696.60 | 87.07 | 100.0% | 22.1 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 30 | 2309.10 | 76.97 | 100.0% | 12.9 |
| 0-1 | 19 | 942.20 | 49.59 | 100.0% | 6.6 |
| <-3 | 8 | 459.50 | 57.44 | 100.0% | 5.1 |
| -2--1 | 7 | 504.40 | 72.06 | 100.0% | 12.0 |
| -3--2 | 7 | 283.00 | 40.43 | 100.0% | 8.4 |
| -1-0 | 6 | 293.70 | 48.95 | 100.0% | 5.8 |
| 1-2 | 6 | 379.50 | 63.25 | 100.0% | 13.5 |
| 2-3 | 6 | 689.10 | 114.85 | 100.0% | 17.8 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 35 | 2517.70 | 71.93 | 100.0% | 11.9 |
| -1-0 | 30 | 2018.40 | 67.28 | 100.0% | 14.0 |
| 1-2 | 17 | 1084.50 | 63.79 | 100.0% | 5.8 |
| -2--1 | 7 | 239.90 | 34.27 | 100.0% | 26.0 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 32 | 1704.50 | 53.27 | 100.0% | 13.8 |
| 4-8 | 21 | 2201.20 | 104.82 | 100.0% | 12.0 |
| 1-2 | 19 | 1116.70 | 58.77 | 100.0% | 8.4 |
| 0-0.5 | 10 | 466.20 | 46.62 | 100.0% | 4.5 |
| >=8 | 7 | 435.50 | 62.21 | 100.0% | 15.3 |
| 0.5-1 | 6 | 377.80 | 62.97 | 100.0% | 14.0 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 34 | 2092.80 | 61.55 | 100.0% | 12.0 |
| 3 | 31 | 2432.20 | 78.46 | 100.0% | 9.4 |
| 5 | 30 | 1776.90 | 59.23 | 100.0% | 11.9 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 42 | 3102.80 | 73.88 | 100.0% | 13.9 |
| 2-4 | 27 | 1496.90 | 55.44 | 100.0% | 11.9 |
| 4-8 | 21 | 1386.90 | 66.04 | 100.0% | 8.4 |
| 8-12 | 5 | 315.30 | 63.06 | 100.0% | 6.7 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 33 | 2473.80 | 74.96 | 100.0% | 12.7 |
| 2-4 | 17 | 631.30 | 37.14 | 100.0% | 20.0 |
| 1-2 | 12 | 893.40 | 74.45 | 100.0% | 11.9 |
| 4-8 | 12 | 606.00 | 50.50 | 100.0% | 12.0 |
| 0.5-1 | 11 | 959.20 | 87.20 | 100.0% | 3.8 |
| 0-0.5 | 6 | 448.40 | 74.73 | 100.0% | 10.8 |
| >=8 | 4 | 289.80 | 72.45 | 100.0% | 7.6 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 39 | 2641.60 | 67.73 | 100.0% | 8.5 |
| 2-4 | 16 | 1197.70 | 74.86 | 100.0% | 6.9 |
| 1-2 | 13 | 808.10 | 62.16 | 100.0% | 20.0 |
| 4-8 | 12 | 720.50 | 60.04 | 100.0% | 12.6 |
| >=8 | 7 | 489.00 | 69.86 | 100.0% | 14.7 |
| 0-0.5 | 5 | 228.10 | 45.62 | 100.0% | 17.4 |
| 0.5-1 | 3 | 216.90 | 72.30 | 100.0% | 8.8 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2652.90 | 69.81 | 100.0% | 13.9 |
| >=24 | 26 | 931.60 | 35.83 | 100.0% | 2.4 |
| 8-12 | 10 | 1193.50 | 119.35 | 100.0% | 15.2 |
| 16-24 | 7 | 657.60 | 93.94 | 100.0% | 9.4 |
| 2-4 | 7 | 531.30 | 75.90 | 100.0% | 6.5 |
| 12-16 | 4 | 194.10 | 48.52 | 100.0% | 12.0 |
| 0-2 | 3 | 140.90 | 46.97 | 100.0% | 12.0 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 33 | 2295.00 | 69.55 | 100.0% | 8.4 |
| 40-50 | 17 | 1239.90 | 72.94 | 100.0% | 12.7 |
| 60-70 | 17 | 946.80 | 55.69 | 100.0% | 9.9 |
| 70-80 | 17 | 1339.00 | 78.76 | 100.0% | 12.0 |
| 80-90 | 11 | 481.20 | 43.75 | 100.0% | 19.8 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 22 | 1494.90 | 67.95 | 100.0% | 12.6 |
| 3-4 | 22 | 1442.00 | 65.55 | 100.0% | 10.3 |
| 2-3 | 18 | 830.60 | 46.14 | 100.0% | 13.8 |
| 5-6 | 14 | 790.00 | 56.43 | 100.0% | 7.2 |
| 4-5 | 11 | 1272.50 | 115.68 | 100.0% | 5.5 |
| <1 | 8 | 471.90 | 58.99 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 95 | 6301.90 | 66.34 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 95 | 6301.90 | 66.34 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2652.90 | 69.81 | 100.0% | 13.9 |
| >=24 | 26 | 931.60 | 35.83 | 100.0% | 2.4 |
| 8-12 | 10 | 1193.50 | 119.35 | 100.0% | 15.2 |
| 16-24 | 7 | 657.60 | 93.94 | 100.0% | 9.4 |
| 2-4 | 7 | 531.30 | 75.90 | 100.0% | 6.5 |
| 12-16 | 4 | 194.10 | 48.52 | 100.0% | 12.0 |
| 0-2 | 3 | 140.90 | 46.97 | 100.0% | 12.0 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 66 | 4085.20 | 61.90 | 100.0% | 8.6 |
| 2-4 | 11 | 1104.80 | 100.44 | 100.0% | 19.8 |
| 4-6 | 9 | 624.50 | 69.39 | 100.0% | 12.0 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| >=12 | 3 | 104.00 | 34.67 | 100.0% | 23.3 |
| 8-12 | 2 | 241.40 | 120.70 | 100.0% | 15.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 31 | 2753.10 | 88.81 | 100.0% | 9.4 |
| <5 | 27 | 1917.60 | 71.02 | 100.0% | 1.2 |
| 15-30 | 25 | 807.70 | 32.31 | 100.0% | 19.8 |
| 60-180 | 7 | 263.00 | 37.57 | 100.0% | 90.2 |
| 30-60 | 3 | 88.00 | 29.33 | 100.0% | 35.4 |
| 180-720 | 2 | 472.50 | 236.25 | 100.0% | 193.1 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 95 | 6301.90 | 66.34 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 69 | 4634.00 | 67.16 | 100.0% | 8.8 |
| VALID_1DTE_ONLY | 20 | 1298.70 | 64.93 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 161.80 | 32.36 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 69 | 4634.00 | 67.16 | 100.0% | 8.8 |
| VALID_1DTE_ONLY | 20 | 1298.70 | 64.93 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 161.80 | 32.36 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 61 | 3811.50 | 62.48 | 8.7 | 14.5 | 262.74 | 0 |
| 2026-07 | 34 | 2490.40 | 73.25 | 14.4 | 20.1 | 124.07 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.40 | 31 | 1160.20 | 37.43 | 3.0 |
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
