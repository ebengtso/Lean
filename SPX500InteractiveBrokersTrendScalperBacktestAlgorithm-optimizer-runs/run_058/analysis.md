# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_058/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_058/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 101
- Entry signals: 101
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8036
- Total paired trade PnL: 7419.80
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 20.6 minutes

## Lean Runtime Statistics
- Equity: $107,419.80
- Net Profit: $7,419.80
- Return: 7.42 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $45,161,281.60

## Risk And Efficiency
- Exposure hours: 34.7
- PnL per exposure hour: 213.65
- Calendar span days: 12.3
- PnL per calendar day: 602.38
- Trades per calendar day: 8.20
- Exposure share of calendar time: 11.7%
- Growth quality score: 11294.6
- VIX stale at entry: 0.0%
- ES stale rows: 9.3%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 62
- Fast PnL per exposure hour: 782.72

## Pullback Broken Structure Veto
- Blocked signal rows: 1234
- Blocked by profile: `{"charm_pin_pullback_long": 1182, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 2, "charm_pin_pullback_long": 26, "charm_wall_breakaway_long": 5, "delta_charm_breakout_long": 1, "pullback_long": 31, "pullback_long_no_0dte": 3, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1315.299999999992, "breakout_long_no_0dte": 278.40000000001237, "call_wall_acceptance_long": 640.5, "charm_pin_pullback_long": 922.4000000001206, "charm_wall_breakaway_long": 986.9999999999873, "delta_charm_breakout_long": 41.99999999999363, "pullback_long": 2419.4000000001934, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 723.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=36.0201, sortinoRatio=0, alpha=0, beta=0, informationRatio=36.6303, drawdown=0.007
- Trades: sharpeRatio=0.8911, averageMAE=-102.3564, averageMFE=93.0748, largestMAE=-655.2, largestMFE=592.8, maximumIntraTradeDrawdown=-1248.0

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 2419.40 | 78.05 | 100.0% | 12.0 | 9.6 | 252.90 | 0 | -403.20 | 99.00 | 3.33 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1315.30 | 65.76 | 100.0% | 14.1 | 7.7 | 170.09 | 0 | -386.75 | 79.88 | 3.00 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 987.00 | 197.40 | 100.0% | 16.0 | 4.2 | 234.69 | 0 | -357.00 | 150.50 | 12.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 26 | 922.40 | 35.48 | 100.0% | 2.5 | 3.9 | 238.72 | 0 | -264.35 | 41.65 | 2.40 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 723.00 | 72.30 | 100.0% | 15.7 | 3.9 | 187.68 | 0 | -214.20 | 77.78 | 33.59 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 2 | 640.50 | 320.25 | 100.0% | 66.2 | 2.2 | 290.29 | 0 | -655.20 | 364.57 | 24.81 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 | 0.2 | 845.57 | 0 | -76.50 | 243.10 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 91.80 | 30.60 | 100.0% | 16.4 | 1.1 | 83.22 | 0 | -103.50 | 27.90 | 4.00 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 71.00 | 35.50 | 100.0% | 52.6 | 1.8 | 40.51 | 0 | -250.25 | 62.27 | 6.00 |
| delta_charm_breakout_long | true | VALID_0DTE | VALID_0DTE | 1 | 42.00 | 42.00 | 100.0% | 12.0 | 0.2 | 210.00 | 0 | -71.75 | 78.75 | 12.00 |
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
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 75.96 | 21.06 | 57.99 | 17.35 | 50.5 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 26 | 61.87 | 29.70 | 43.29 | 18.82 | 8.9 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 2 | 72.97 | 22.88 | 54.16 | 28.60 | 66.2 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 70.88 | 7.38 | 81.57 | 27.17 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 54.55 | 5.48 | 48.15 | 19.52 | 22.1 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 78.32 | 11.24 | 80.45 | 28.97 | 52.6 | 0 |
| delta_charm_breakout_long | true | VALID_0DTE | VALID_0DTE | 1 | 86.68 | 17.61 | 62.29 | 35.50 | 12.0 | 0 |
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
- MAE: average -103.38, median -72.42, worst -655.20
- MFE: average 93.07, median 66.30, best 592.80
- Average MFE / absolute MAE: 0.90

## Intratrade Path
- Trades with path stats: 101; with intratrade price samples: 101
- Went positive before max adverse: 51.5%
- MFE happened before MAE: 9.9%
- TP touched before MAE: 1.0%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 2.8 minutes
- Median first +1.5 points: 2.9 minutes
- First 15m MFE/MAE medians: 2.40 / -1.95 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T11:59:48+00:00` -> `2026-06-26T14:00:11+00:00`.
- Strategy/profile: `call_wall_acceptance_long` / `call_wall_acceptance_long`. PnL 546.00, MAE -655.20, MFE 592.80, hold 120.4 minutes.
- Profile context: `call_wall_acceptance_long` produced 2 trades, PnL 640.50, 0 slow >=12h trades, and 8.6% of total PnL.
- Entry state: setup=73.44, ES-VWAP=28.76, VWAP slope=0.0302, VWAP acceleration=-0.0176, RSI=54.73, ADX=14.45, structure score=5.00, higher-low=4.25, higher-high=3.00, pullback-from-high=4.50, rolling-high distance=4.50.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=2.00, slow-risk points=0.00.
- Existing warning reason: RSI slope -2.5746 <= -2.0000; ADX 14.45 <= 18.00.
- Strategy selection reason: positive gamma call-wall acceptance: callPutVolumeImbalance=0.8914, callWall=7400.00, target=7458.20, distance=14.50, forwardDexRatio30m=0.6066.
- Intratrade path: path MFE 21.00, path MAE -22.70, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 73.5` would block this trade, keep 19 trades, retain 17.6% PnL, and leave worst MAE -386.75. It would block 82 trades total.
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
| `es_structure_rising_vwap != "False"` | 20 | 7 | 13 | 81 | 5933.70 | 1486.10 | 80.0% | -655.20 | 15838.4 |
| `long_strategy != "breakout_long_1dte"` | 20 | 6 | 14 | 81 | 6104.50 | 1315.30 | 82.3% | -655.20 | 15798.0 |
| `strategy_profile != "breakout_long_1dte"` | 20 | 6 | 14 | 81 | 6104.50 | 1315.30 | 82.3% | -655.20 | 15798.0 |
| `option_strike_map_selected_tp_source != "target_2_upper_straddle"` | 20 | 4 | 10 | 87 | 5309.20 | 2110.60 | 71.6% | -403.20 | 12499.1 |
| `path_first_observed_seconds >= 2` | 20 | 5 | 16 | 80 | 6226.10 | 1193.70 | 83.9% | -655.20 | 111.1 |
| `path_first_nonzero_move_seconds >= 2` | 20 | 5 | 16 | 80 | 6226.10 | 1193.70 | 83.9% | -655.20 | 111.1 |
| `path_first_observed_seconds >= 3` | 20 | 6 | 22 | 73 | 5525.40 | 1894.40 | 74.5% | -655.20 | 46.0 |
| `path_first_nonzero_move_seconds >= 3` | 20 | 6 | 22 | 73 | 5525.40 | 1894.40 | 74.5% | -655.20 | 46.0 |
| `option_strike_map_target_2_strike <= 7600.52` | 20 | 5 | 19 | 77 | 5876.80 | 1543.00 | 79.2% | -655.20 | 43.8 |
| `path_first_observed_seconds <= 9` | 20 | 6 | 23 | 72 | 5460.10 | 1959.70 | 73.6% | -403.20 | 32.8 |
| `path_first_observed_seconds <= 10` | 20 | 5 | 17 | 79 | 5769.70 | 1650.10 | 77.8% | -403.20 | 27.5 |
| `path_first_nonzero_move_seconds <= 10` | 20 | 5 | 17 | 79 | 5769.70 | 1650.10 | 77.8% | -403.20 | 27.5 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36243
- position_wait: 8036
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1504
- trade_risk_tighten_signal: 555
- order_event: 458
- waiting_spx_quote: 415
- entry_signal: 101

## Blocked Gate Counts
- setup_quality_allowed: 14436 (disabled=14436)
- above_vwap_confirmed: 9090 (disabled=9090)
- above_vwap: 8083 (disabled=8083)
- es_structure_allowed: 7817 (disabled=7817)
- pullback: 6386 (disabled=6386)
- momentum: 4210 (disabled=4210)
- es_vwap_max_distance_allowed: 4129 (disabled=4129)
- es_vwap_slope_allowed: 3676 (disabled=3676)
- trend_strength: 3397 (disabled=3397)
- es_vwap_acceleration_allowed: 2221 (disabled=2221)
- es_rolling_high_allowed: 528 (disabled=528)
- indicator_slope_allowed: 171 (disabled=171)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 735.60 | 61.30 | 100.0% | 0.4 |
| 8 | 11 | 1308.10 | 118.92 | 100.0% | 16.6 |
| 14 | 9 | 816.00 | 90.67 | 100.0% | 2.3 |
| 1 | 6 | 515.30 | 85.88 | 100.0% | 3.0 |
| 12 | 6 | 246.30 | 41.05 | 100.0% | 12.4 |
| 15 | 6 | 391.90 | 65.32 | 100.0% | 6.0 |
| 18 | 5 | 296.80 | 59.36 | 100.0% | 12.0 |
| 19 | 5 | 276.20 | 55.24 | 100.0% | 8.4 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 9 | 5 | 236.80 | 47.36 | 100.0% | 16.0 |
| 11 | 4 | 686.80 | 171.70 | 100.0% | 11.3 |
| 2 | 4 | 214.50 | 53.63 | 100.0% | 48.6 |
| 22 | 4 | 393.90 | 98.48 | 100.0% | 14.9 |
| 7 | 4 | 243.40 | 60.85 | 100.0% | 12.0 |
| 0 | 3 | 178.50 | 59.50 | 100.0% | 12.1 |
| 10 | 2 | 52.00 | 26.00 | 100.0% | 16.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 53 | 3714.40 | 70.08 | 100.0% | 8.4 |
| 55-60 | 16 | 1345.90 | 84.12 | 100.0% | 13.0 |
| >=75 | 11 | 1016.70 | 92.43 | 100.0% | 9.9 |
| 70-75 | 9 | 449.00 | 49.89 | 100.0% | 20.0 |
| 60-65 | 6 | 310.00 | 51.67 | 100.0% | 27.6 |
| 65-70 | 6 | 583.80 | 97.30 | 100.0% | 14.2 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 41 | 3319.90 | 80.97 | 100.0% | 8.8 |
| 30-40 | 21 | 1173.70 | 55.89 | 100.0% | 12.0 |
| 20-25 | 19 | 1615.30 | 85.02 | 100.0% | 12.2 |
| 25-30 | 17 | 1068.30 | 62.84 | 100.0% | 12.1 |
| 40-50 | 2 | 203.00 | 101.50 | 100.0% | 7.3 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 101 | 7419.80 | 73.46 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 97 | 6813.30 | 70.24 | 100.0% | 12.0 |
| 0.25-0.5 | 4 | 606.50 | 151.63 | 100.0% | 10.7 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 50 | 3298.20 | 65.96 | 100.0% | 12.0 |
| -0.05-0 | 32 | 2696.40 | 84.26 | 100.0% | 7.2 |
| 0.1-0.25 | 11 | 1080.70 | 98.25 | 100.0% | 14.7 |
| 0.05-0.1 | 6 | 291.50 | 48.58 | 100.0% | 20.5 |
| -0.1--0.05 | 1 | 17.00 | 17.00 | 100.0% | 18.7 |
| >=0.25 | 1 | 36.00 | 36.00 | 100.0% | 81.9 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 28 | 2026.20 | 72.36 | 100.0% | 6.4 |
| 2-4 | 21 | 1146.40 | 54.59 | 100.0% | 15.6 |
| 0-1 | 20 | 1644.20 | 82.21 | 100.0% | 13.9 |
| 6-8 | 14 | 1450.40 | 103.60 | 100.0% | 10.7 |
| 1-2 | 6 | 400.20 | 66.70 | 100.0% | 18.6 |
| 8-12 | 6 | 270.50 | 45.08 | 100.0% | 15.7 |
| 12-20 | 5 | 446.90 | 89.38 | 100.0% | 3.8 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 36 | 2542.40 | 70.62 | 100.0% | 7.9 |
| <1 | 23 | 1815.90 | 78.95 | 100.0% | 14.7 |
| 1-3 | 12 | 902.60 | 75.22 | 100.0% | 19.0 |
| 10-20 | 12 | 675.10 | 56.26 | 100.0% | 11.7 |
| 5-10 | 12 | 1145.70 | 95.48 | 100.0% | 10.5 |
| 3-5 | 5 | 271.60 | 54.32 | 100.0% | 11.9 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 33 | 2586.30 | 78.37 | 100.0% | 12.0 |
| 0-1 | 21 | 1062.80 | 50.61 | 100.0% | 6.6 |
| -2--1 | 9 | 619.50 | 68.83 | 100.0% | 8.8 |
| -3--2 | 8 | 803.50 | 100.44 | 100.0% | 11.4 |
| 1-2 | 7 | 489.00 | 69.86 | 100.0% | 15.0 |
| 2-3 | 7 | 744.40 | 106.34 | 100.0% | 15.6 |
| -1-0 | 6 | 510.30 | 85.05 | 100.0% | 14.1 |
| <-3 | 6 | 244.20 | 40.70 | 100.0% | 7.1 |
| missing | 4 | 359.80 | 89.95 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 39 | 2599.70 | 66.66 | 100.0% | 12.0 |
| -1-0 | 33 | 3009.40 | 91.19 | 100.0% | 12.0 |
| 1-2 | 16 | 1135.20 | 70.95 | 100.0% | 5.1 |
| -2--1 | 9 | 315.70 | 35.08 | 100.0% | 26.0 |
| missing | 4 | 359.80 | 89.95 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 32 | 2210.00 | 69.06 | 100.0% | 15.1 |
| 4-8 | 19 | 2149.80 | 113.15 | 100.0% | 12.0 |
| 1-2 | 18 | 1078.80 | 59.93 | 100.0% | 7.8 |
| >=8 | 16 | 1114.90 | 69.68 | 100.0% | 15.3 |
| 0-0.5 | 10 | 514.00 | 51.40 | 100.0% | 5.7 |
| 0.5-1 | 6 | 352.30 | 58.72 | 100.0% | 12.5 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3 | 34 | 2669.90 | 78.53 | 100.0% | 12.0 |
| 4 | 34 | 2320.60 | 68.25 | 100.0% | 13.4 |
| 5 | 32 | 2395.30 | 74.85 | 100.0% | 10.3 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 47 | 3702.00 | 78.77 | 100.0% | 13.2 |
| 2-4 | 30 | 1669.30 | 55.64 | 100.0% | 9.7 |
| 4-8 | 22 | 1997.50 | 90.80 | 100.0% | 8.9 |
| 8-12 | 2 | 51.00 | 25.50 | 100.0% | 18.0 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 37 | 2742.20 | 74.11 | 100.0% | 12.1 |
| 2-4 | 17 | 610.30 | 35.90 | 100.0% | 18.7 |
| 0.5-1 | 12 | 1011.70 | 84.31 | 100.0% | 4.8 |
| 1-2 | 11 | 852.30 | 77.48 | 100.0% | 13.2 |
| 4-8 | 10 | 1051.70 | 105.17 | 100.0% | 10.9 |
| 0-0.5 | 7 | 538.10 | 76.87 | 100.0% | 9.7 |
| >=8 | 7 | 613.50 | 87.64 | 100.0% | 12.0 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 39 | 2772.80 | 71.10 | 100.0% | 8.5 |
| 1-2 | 16 | 915.50 | 57.22 | 100.0% | 21.8 |
| 2-4 | 16 | 1746.00 | 109.13 | 100.0% | 6.9 |
| 4-8 | 13 | 1031.10 | 79.32 | 100.0% | 12.1 |
| >=8 | 8 | 473.40 | 59.17 | 100.0% | 15.7 |
| 0-0.5 | 5 | 228.10 | 45.62 | 100.0% | 17.4 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2677.40 | 70.46 | 100.0% | 13.9 |
| >=24 | 24 | 1368.80 | 57.03 | 100.0% | 2.3 |
| 8-12 | 14 | 1506.70 | 107.62 | 100.0% | 23.5 |
| 2-4 | 8 | 593.50 | 74.19 | 100.0% | 9.3 |
| 16-24 | 7 | 706.10 | 100.87 | 100.0% | 12.0 |
| 12-16 | 6 | 340.00 | 56.67 | 100.0% | 13.0 |
| 0-2 | 4 | 227.30 | 56.82 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 34 | 2433.10 | 71.56 | 100.0% | 6.6 |
| 60-70 | 22 | 1280.60 | 58.21 | 100.0% | 12.0 |
| 70-80 | 19 | 1987.00 | 104.58 | 100.0% | 12.1 |
| 40-50 | 17 | 1251.40 | 73.61 | 100.0% | 12.7 |
| 80-90 | 9 | 467.70 | 51.97 | 100.0% | 16.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 23 | 1656.10 | 72.00 | 100.0% | 12.0 |
| 2-3 | 20 | 1402.90 | 70.15 | 100.0% | 16.2 |
| 3-4 | 19 | 1267.70 | 66.72 | 100.0% | 12.0 |
| 5-6 | 15 | 814.90 | 54.33 | 100.0% | 7.3 |
| 4-5 | 14 | 1492.10 | 106.58 | 100.0% | 7.5 |
| <1 | 10 | 786.10 | 78.61 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 101 | 7419.80 | 73.46 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 101 | 7419.80 | 73.46 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2677.40 | 70.46 | 100.0% | 13.9 |
| >=24 | 24 | 1368.80 | 57.03 | 100.0% | 2.3 |
| 8-12 | 14 | 1506.70 | 107.62 | 100.0% | 23.5 |
| 2-4 | 8 | 593.50 | 74.19 | 100.0% | 9.3 |
| 16-24 | 7 | 706.10 | 100.87 | 100.0% | 12.0 |
| 12-16 | 6 | 340.00 | 56.67 | 100.0% | 13.0 |
| 0-2 | 4 | 227.30 | 56.82 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 61 | 3853.60 | 63.17 | 100.0% | 8.6 |
| 2-4 | 13 | 1196.70 | 92.05 | 100.0% | 24.9 |
| 4-6 | 9 | 634.10 | 70.46 | 100.0% | 12.0 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| >=12 | 5 | 230.80 | 46.16 | 100.0% | 16.6 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| 0-1 | 2 | 640.50 | 320.25 | 100.0% | 66.2 |
| 6-8 | 2 | 72.00 | 36.00 | 100.0% | 40.7 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 35 | 3309.80 | 94.57 | 100.0% | 11.9 |
| <5 | 27 | 1894.40 | 70.16 | 100.0% | 1.6 |
| 15-30 | 26 | 854.10 | 32.85 | 100.0% | 18.9 |
| 60-180 | 7 | 742.00 | 106.00 | 100.0% | 90.5 |
| 30-60 | 5 | 169.50 | 33.90 | 100.0% | 38.0 |
| 180-720 | 1 | 450.00 | 450.00 | 100.0% | 198.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 101 | 7419.80 | 73.46 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 75 | 5734.30 | 76.46 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1315.30 | 65.76 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 75 | 5734.30 | 76.46 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1315.30 | 65.76 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 63 | 4625.80 | 73.43 | 10.8 | 15.4 | 300.21 | 0 |
| 2026-07 | 38 | 2794.00 | 73.53 | 14.4 | 19.3 | 144.61 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 86.40 | 86.40 | 3.0 |
| 2.40 | 26 | 922.40 | 35.48 | 2.5 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1315.30 | 65.76 | 14.1 |
| 3.02 | 2 | 147.60 | 73.80 | 49.9 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.13 | 1 | 61.20 | 61.20 | 12.0 |
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
| 3.60 | 6 | 545.30 | 90.88 | 9.5 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 3 | 278.40 | 92.80 | 23.3 |
| 12.00 | 6 | 1029.00 | 171.50 | 14.0 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 15.00 | 1 | 45.50 | 45.50 | 44.6 |
| 16.25 | 1 | 36.00 | 36.00 | 23.6 |
| 20.95 | 1 | 546.00 | 546.00 | 120.4 |
| 23.75 | 1 | 36.00 | 36.00 | 57.7 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 28.66 | 1 | 94.50 | 94.50 | 12.0 |
| 38.75 | 2 | 125.80 | 62.90 | 14.7 |
| 48.62 | 2 | 71.00 | 35.50 | 19.9 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
