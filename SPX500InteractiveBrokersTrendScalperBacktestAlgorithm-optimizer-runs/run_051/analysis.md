# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_051/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_051/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 104
- Entry signals: 104
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8257
- Total paired trade PnL: 7325.70
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 20.6 minutes

## Lean Runtime Statistics
- Equity: $107,325.70
- Net Profit: $7,325.70
- Return: 7.33 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $45,879,188.10

## Risk And Efficiency
- Exposure hours: 35.6
- PnL per exposure hour: 205.51
- Calendar span days: 12.3
- PnL per calendar day: 594.74
- Trades per calendar day: 8.44
- Exposure share of calendar time: 12.1%
- Growth quality score: 11210.7
- VIX stale at entry: 0.0%
- ES stale rows: 9.3%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 65
- Fast PnL per exposure hour: 739.07

## Pullback Broken Structure Veto
- Blocked signal rows: 1201
- Blocked by profile: `{"charm_pin_pullback_long": 1149, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 2, "charm_pin_pullback_long": 31, "charm_wall_breakaway_long": 3, "pullback_long": 32, "pullback_long_no_0dte": 3, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1315.299999999992, "breakout_long_no_0dte": 284.50000000001273, "call_wall_acceptance_long": 637.0, "charm_pin_pullback_long": 1201.0000000001428, "charm_wall_breakaway_long": 533.9999999999873, "pullback_long": 2541.1000000002186, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 721.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=36.2016, sortinoRatio=0, alpha=0, beta=0, informationRatio=36.8468, drawdown=0.007
- Trades: sharpeRatio=0.9510, averageMAE=-102.8221, averageMFE=89.3409, largestMAE=-655.2, largestMFE=592.8, maximumIntraTradeDrawdown=-1248.0

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 2541.10 | 79.41 | 100.0% | 12.0 | 9.8 | 260.21 | 0 | -403.20 | 102.10 | 3.33 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1315.30 | 65.76 | 100.0% | 14.1 | 7.7 | 170.09 | 0 | -386.75 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 1201.00 | 38.74 | 100.0% | 2.8 | 5.2 | 230.70 | 0 | -335.75 | 42.50 | 2.40 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 721.00 | 72.10 | 100.0% | 15.7 | 3.9 | 187.16 | 0 | -208.25 | 77.78 | 33.59 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 2 | 637.00 | 318.50 | 100.0% | 66.2 | 2.2 | 288.71 | 0 | -655.20 | 362.05 | 24.81 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 3 | 534.00 | 178.00 | 100.0% | 16.6 | 3.8 | 141.19 | 0 | -357.00 | 150.50 | 12.00 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 213.50 | 213.50 | 100.0% | 14.7 | 0.2 | 870.44 | 0 | -78.75 | 250.25 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 91.80 | 30.60 | 100.0% | 16.4 | 1.1 | 83.22 | 0 | -103.50 | 27.90 | 4.00 |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 32 | 50.21 | 6.57 | 48.90 | 20.37 | 18.3 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 66.79 | 29.56 | 48.91 | 21.17 | 10.1 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 2 | 72.97 | 22.88 | 54.16 | 28.60 | 66.2 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 3 | 66.74 | 13.23 | 56.56 | 17.35 | 75.6 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 70.88 | 7.38 | 81.57 | 27.17 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 54.55 | 5.48 | 48.15 | 19.52 | 22.1 | 0 |
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
- MAE: average -103.82, median -70.20, worst -655.20
- MFE: average 89.34, median 64.65, best 592.80
- Average MFE / absolute MAE: 0.86

## Intratrade Path
- Trades with path stats: 104; with intratrade price samples: 104
- Went positive before max adverse: 51.9%
- MFE happened before MAE: 9.6%
- TP touched before MAE: 1.0%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 2.8 minutes
- Median first +1.5 points: 2.8 minutes
- First 15m MFE/MAE medians: 2.40 / -1.92 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T11:59:48+00:00` -> `2026-06-26T14:00:11+00:00`.
- Strategy/profile: `call_wall_acceptance_long` / `call_wall_acceptance_long`. PnL 546.00, MAE -655.20, MFE 592.80, hold 120.4 minutes.
- Profile context: `call_wall_acceptance_long` produced 2 trades, PnL 637.00, 0 slow >=12h trades, and 8.7% of total PnL.
- Entry state: setup=73.44, ES-VWAP=28.76, VWAP slope=0.0302, VWAP acceleration=-0.0176, RSI=54.73, ADX=14.45, structure score=5.00, higher-low=4.25, higher-high=3.00, pullback-from-high=4.50, rolling-high distance=4.50.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=2.00, slow-risk points=0.00.
- Existing warning reason: RSI slope -2.5746 <= -2.0000; ADX 14.45 <= 18.00.
- Strategy selection reason: positive gamma call-wall acceptance: callPutVolumeImbalance=0.8914, callWall=7400.00, target=7458.20, distance=14.50, forwardDexRatio30m=0.6066.
- Intratrade path: path MFE 21.00, path MAE -22.70, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 73.5` would block this trade, keep 20 trades, retain 14.0% PnL, and leave worst MAE -386.75. It would block 84 trades total.
- No single candidate threshold in the report cleanly removes this tail; the closest visible guard is setup quality 73.44.

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
| `es_structure_rising_vwap != "False"` | 20 | 7 | 13 | 84 | 5834.50 | 1491.20 | 79.6% | -655.20 | 15839.9 |
| `long_strategy != "breakout_long_1dte"` | 20 | 6 | 14 | 84 | 6010.40 | 1315.30 | 82.0% | -655.20 | 15800.7 |
| `strategy_profile != "breakout_long_1dte"` | 20 | 6 | 14 | 84 | 6010.40 | 1315.30 | 82.0% | -655.20 | 15800.7 |
| `option_strike_map_selected_tp_source != "target_2_upper_straddle"` | 20 | 4 | 7 | 93 | 5718.70 | 1607.00 | 78.1% | -403.20 | 12617.9 |
| `path_half_tp_touch_minutes >= 0.183333` | 20 | 12 | 23 | 69 | 5575.90 | 1749.80 | 76.1% | -655.20 | 490.5 |
| `es_structure_pullback_from_high <= 3.25` | 20 | 8 | 25 | 71 | 5155.30 | 2170.40 | 70.4% | -403.20 | 131.8 |
| `adx14 <= 36.33` | 20 | 4 | 9 | 91 | 6543.70 | 782.00 | 89.3% | -655.20 | 125.7 |
| `es_reclaim_samples <= 558` | 20 | 5 | 15 | 84 | 6079.10 | 1246.60 | 83.0% | -655.20 | 103.1 |
| `es_structure_pullback_from_high <= 3.75` | 20 | 7 | 22 | 75 | 5299.80 | 2025.90 | 72.3% | -403.20 | 92.3 |
| `adx14 <= 28.4603` | 20 | 6 | 22 | 76 | 5656.60 | 1669.10 | 77.2% | -655.20 | 86.6 |
| `es_reclaim_samples <= 590` | 20 | 4 | 11 | 89 | 6304.90 | 1020.80 | 86.1% | -655.20 | 79.8 |
| `adx14 <= 29.9428` | 20 | 5 | 19 | 80 | 5858.90 | 1466.80 | 80.0% | -655.20 | 57.5 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36022
- position_wait: 8257
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1504
- trade_risk_tighten_signal: 589
- order_event: 469
- waiting_spx_quote: 414
- entry_signal: 104

## Blocked Gate Counts
- setup_quality_allowed: 14427 (disabled=14427)
- above_vwap_confirmed: 9063 (disabled=9063)
- above_vwap: 8054 (disabled=8054)
- es_structure_allowed: 7881 (disabled=7881)
- pullback: 6650 (disabled=6650)
- momentum: 4184 (disabled=4184)
- es_vwap_max_distance_allowed: 3936 (disabled=3936)
- es_vwap_slope_allowed: 3685 (disabled=3685)
- trend_strength: 3392 (disabled=3392)
- es_vwap_acceleration_allowed: 1895 (disabled=1895)
- es_rolling_high_allowed: 498 (disabled=498)
- indicator_slope_allowed: 156 (disabled=156)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 735.60 | 61.30 | 100.0% | 0.4 |
| 8 | 11 | 1304.70 | 118.61 | 100.0% | 16.6 |
| 14 | 10 | 477.60 | 47.76 | 100.0% | 1.5 |
| 15 | 7 | 452.10 | 64.59 | 100.0% | 6.5 |
| 1 | 6 | 515.30 | 85.88 | 100.0% | 3.0 |
| 11 | 5 | 707.20 | 141.44 | 100.0% | 12.0 |
| 12 | 5 | 225.80 | 45.16 | 100.0% | 12.2 |
| 18 | 5 | 296.80 | 59.36 | 100.0% | 12.0 |
| 19 | 5 | 276.20 | 55.24 | 100.0% | 8.4 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 9 | 5 | 290.80 | 58.16 | 100.0% | 12.0 |
| 2 | 4 | 214.50 | 53.63 | 100.0% | 48.6 |
| 22 | 4 | 400.00 | 100.00 | 100.0% | 14.9 |
| 7 | 4 | 241.70 | 60.42 | 100.0% | 12.0 |
| 0 | 3 | 178.50 | 59.50 | 100.0% | 12.1 |
| 10 | 3 | 181.20 | 60.40 | 100.0% | 14.0 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 56 | 4010.90 | 71.62 | 100.0% | 7.2 |
| 55-60 | 16 | 1327.20 | 82.95 | 100.0% | 13.0 |
| >=75 | 11 | 1022.80 | 92.98 | 100.0% | 9.9 |
| 70-75 | 9 | 448.00 | 49.78 | 100.0% | 20.0 |
| 60-65 | 7 | 353.00 | 50.43 | 100.0% | 29.4 |
| 65-70 | 5 | 163.80 | 32.76 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 41 | 3409.30 | 83.15 | 100.0% | 8.8 |
| 20-25 | 21 | 1292.90 | 61.57 | 100.0% | 12.2 |
| 30-40 | 19 | 1164.80 | 61.31 | 100.0% | 12.0 |
| 25-30 | 18 | 1156.70 | 64.26 | 100.0% | 12.1 |
| 40-50 | 4 | 262.40 | 65.60 | 100.0% | 17.4 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 104 | 7325.70 | 70.44 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 100 | 7123.40 | 71.23 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 185.30 | 61.77 | 100.0% | 5.8 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 49 | 3238.00 | 66.08 | 100.0% | 12.0 |
| -0.05-0 | 34 | 2781.30 | 81.80 | 100.0% | 7.8 |
| 0.1-0.25 | 10 | 665.60 | 66.56 | 100.0% | 15.7 |
| 0.05-0.1 | 6 | 290.50 | 48.42 | 100.0% | 20.5 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.1--0.05 | 1 | 125.80 | 125.80 | 100.0% | 11.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |
| <-0.25 | 1 | 84.00 | 84.00 | 100.0% | 2.4 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 29 | 2039.80 | 70.34 | 100.0% | 5.8 |
| 2-4 | 22 | 1212.70 | 55.12 | 100.0% | 15.4 |
| 0-1 | 19 | 1616.30 | 85.07 | 100.0% | 13.2 |
| 6-8 | 13 | 1010.50 | 77.73 | 100.0% | 12.1 |
| 12-20 | 7 | 656.70 | 93.81 | 100.0% | 3.8 |
| 8-12 | 7 | 354.50 | 50.64 | 100.0% | 14.0 |
| 1-2 | 6 | 400.20 | 66.70 | 100.0% | 18.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 34 | 2454.60 | 72.19 | 100.0% | 8.0 |
| <1 | 23 | 1805.00 | 78.48 | 100.0% | 14.7 |
| 5-10 | 13 | 1362.30 | 104.79 | 100.0% | 8.8 |
| 10-20 | 12 | 653.00 | 54.42 | 100.0% | 12.3 |
| 1-3 | 11 | 481.40 | 43.76 | 100.0% | 20.6 |
| 3-5 | 10 | 502.90 | 50.29 | 100.0% | 10.2 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 34 | 2225.00 | 65.44 | 100.0% | 12.0 |
| 0-1 | 21 | 1110.40 | 52.88 | 100.0% | 5.5 |
| -3--2 | 8 | 829.00 | 103.63 | 100.0% | 10.2 |
| 1-2 | 8 | 613.80 | 76.73 | 100.0% | 13.5 |
| -1-0 | 7 | 552.80 | 78.97 | 100.0% | 12.0 |
| -2--1 | 7 | 514.60 | 73.51 | 100.0% | 12.0 |
| <-3 | 7 | 335.10 | 47.87 | 100.0% | 6.7 |
| 2-3 | 6 | 703.60 | 117.27 | 100.0% | 17.8 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 36 | 2153.00 | 59.81 | 100.0% | 12.0 |
| -1-0 | 35 | 3193.70 | 91.25 | 100.0% | 12.0 |
| 1-2 | 19 | 1237.20 | 65.12 | 100.0% | 7.3 |
| -2--1 | 8 | 300.40 | 37.55 | 100.0% | 21.3 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 34 | 2332.40 | 68.60 | 100.0% | 13.8 |
| 4-8 | 20 | 1854.60 | 92.73 | 100.0% | 10.9 |
| 1-2 | 18 | 1078.80 | 59.93 | 100.0% | 7.8 |
| >=8 | 16 | 1212.30 | 75.77 | 100.0% | 14.4 |
| 0-0.5 | 10 | 469.80 | 46.98 | 100.0% | 4.5 |
| 0.5-1 | 6 | 377.80 | 62.97 | 100.0% | 14.0 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3 | 36 | 2385.50 | 66.26 | 100.0% | 12.0 |
| 4 | 35 | 2487.80 | 71.08 | 100.0% | 12.0 |
| 5 | 32 | 2418.40 | 75.58 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 46 | 3667.90 | 79.74 | 100.0% | 12.6 |
| 2-4 | 29 | 1631.90 | 56.27 | 100.0% | 11.9 |
| 4-8 | 24 | 1677.60 | 69.90 | 100.0% | 7.8 |
| 8-12 | 3 | 138.50 | 46.17 | 100.0% | 17.3 |
| 12-16 | 1 | 84.00 | 84.00 | 100.0% | 2.4 |
| 16-24 | 1 | 125.80 | 125.80 | 100.0% | 11.9 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 38 | 2423.80 | 63.78 | 100.0% | 12.0 |
| 2-4 | 17 | 637.50 | 37.50 | 100.0% | 20.0 |
| 1-2 | 13 | 1028.40 | 79.11 | 100.0% | 11.9 |
| 0.5-1 | 11 | 969.20 | 88.11 | 100.0% | 3.8 |
| 4-8 | 10 | 1030.60 | 103.06 | 100.0% | 12.0 |
| >=8 | 8 | 700.50 | 87.56 | 100.0% | 12.0 |
| 0-0.5 | 7 | 535.70 | 76.53 | 100.0% | 9.7 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 39 | 2745.50 | 70.40 | 100.0% | 8.5 |
| 2-4 | 17 | 1413.70 | 83.16 | 100.0% | 3.0 |
| 1-2 | 14 | 857.70 | 61.26 | 100.0% | 21.8 |
| 4-8 | 14 | 1050.50 | 75.04 | 100.0% | 12.6 |
| >=8 | 9 | 567.50 | 63.06 | 100.0% | 14.7 |
| 0-0.5 | 7 | 437.90 | 62.56 | 100.0% | 16.4 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2682.50 | 70.59 | 100.0% | 13.9 |
| >=24 | 25 | 1392.60 | 55.70 | 100.0% | 2.3 |
| 8-12 | 15 | 1631.50 | 108.77 | 100.0% | 23.3 |
| 12-16 | 8 | 511.50 | 63.94 | 100.0% | 12.0 |
| 2-4 | 8 | 591.80 | 73.97 | 100.0% | 9.3 |
| 16-24 | 6 | 290.90 | 48.48 | 100.0% | 7.0 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 35 | 2596.30 | 74.18 | 100.0% | 6.6 |
| 60-70 | 22 | 1278.60 | 58.12 | 100.0% | 12.0 |
| 70-80 | 20 | 1687.70 | 84.39 | 100.0% | 12.0 |
| 40-50 | 17 | 1251.40 | 73.61 | 100.0% | 12.7 |
| 80-90 | 10 | 511.70 | 51.17 | 100.0% | 18.9 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 24 | 1703.70 | 70.99 | 100.0% | 12.1 |
| 3-4 | 22 | 1413.60 | 64.25 | 100.0% | 11.9 |
| 2-3 | 20 | 1497.90 | 74.90 | 100.0% | 15.9 |
| 5-6 | 15 | 881.90 | 58.79 | 100.0% | 7.2 |
| 4-5 | 14 | 1083.30 | 77.38 | 100.0% | 4.3 |
| <1 | 9 | 745.30 | 82.81 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 104 | 7325.70 | 70.44 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 104 | 7325.70 | 70.44 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2682.50 | 70.59 | 100.0% | 13.9 |
| >=24 | 25 | 1392.60 | 55.70 | 100.0% | 2.3 |
| 8-12 | 15 | 1631.50 | 108.77 | 100.0% | 23.3 |
| 12-16 | 8 | 511.50 | 63.94 | 100.0% | 12.0 |
| 2-4 | 8 | 591.80 | 73.97 | 100.0% | 9.3 |
| 16-24 | 6 | 290.90 | 48.48 | 100.0% | 7.0 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 66 | 3833.90 | 58.09 | 100.0% | 8.5 |
| 2-4 | 13 | 1196.70 | 92.05 | 100.0% | 24.9 |
| 4-6 | 8 | 592.10 | 74.01 | 100.0% | 10.9 |
| 8-12 | 5 | 656.20 | 131.24 | 100.0% | 12.1 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| >=12 | 4 | 197.80 | 49.45 | 100.0% | 20.0 |
| 0-1 | 2 | 637.00 | 318.50 | 100.0% | 66.2 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 37 | 3124.90 | 84.46 | 100.0% | 11.9 |
| <5 | 28 | 1974.30 | 70.51 | 100.0% | 1.0 |
| 15-30 | 26 | 840.50 | 32.33 | 100.0% | 20.3 |
| 60-180 | 7 | 767.50 | 109.64 | 100.0% | 112.5 |
| 30-60 | 5 | 168.50 | 33.70 | 100.0% | 38.0 |
| 180-720 | 1 | 450.00 | 450.00 | 100.0% | 198.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 104 | 7325.70 | 70.44 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 78 | 5634.10 | 72.23 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1315.30 | 65.76 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 213.50 | 213.50 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 78 | 5634.10 | 72.23 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1315.30 | 65.76 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 213.50 | 213.50 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 66 | 4537.90 | 68.76 | 10.9 | 16.3 | 279.14 | 0 |
| 2026-07 | 38 | 2787.80 | 73.36 | 14.4 | 19.4 | 143.78 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 31 | 1201.00 | 38.74 | 2.8 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1315.30 | 65.76 | 14.1 |
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
| 3.48 | 1 | 126.00 | 126.00 | 5.8 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.60 | 7 | 671.10 | 95.87 | 11.9 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 3 | 284.50 | 94.83 | 23.3 |
| 12.00 | 3 | 534.00 | 178.00 | 16.6 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 15.00 | 1 | 45.50 | 45.50 | 44.6 |
| 16.25 | 1 | 35.00 | 35.00 | 23.6 |
| 20.95 | 1 | 546.00 | 546.00 | 120.4 |
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
