# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_049/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_049/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 88
- Entry signals: 89
- Approx open/unpaired entry signals: 1
- Position/order maintenance waits: 15110
- Total paired trade PnL: 5977.00
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 36.3 minutes

## Lean Runtime Statistics
- Equity: $104,871.80
- Net Profit: $5,977.00
- Return: 4.87 %
- Probabilistic Sharpe Ratio: 98.961%
- Volume: $38,670,890.00

## Risk And Efficiency
- Exposure hours: 53.2
- PnL per exposure hour: 112.30
- Calendar span days: 12.3
- PnL per calendar day: 485.24
- Trades per calendar day: 7.14
- Exposure share of calendar time: 18.0%
- Growth quality score: 8857.7
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 1 (1.1%)
- Slow exposure hours: 20.0
- Slow PnL per exposure hour: 1.75
- Fast <15m trades: 54
- Fast PnL per exposure hour: 702.48

## Pullback Broken Structure Veto
- Blocked signal rows: 1002
- Blocked by profile: `{"charm_pin_pullback_long": 962, "pullback_long": 40}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 21, "breakout_long_no_0dte": 3, "charm_pin_pullback_long": 25, "charm_wall_breakaway_long": 4, "pullback_long": 24, "pullback_long_no_0dte": 4, "squeeze_long": 7}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1319.4999999999918, "breakout_long_no_0dte": 276.40000000001237, "charm_pin_pullback_long": 939.200000000068, "charm_wall_breakaway_long": 939.0999999999876, "pullback_long": 1803.6000000000768, "pullback_long_no_0dte": 113.80000000000018, "squeeze_long": 585.3999999999569}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=19.0810, sortinoRatio=51.5187, alpha=0, beta=0, informationRatio=19.7384, drawdown=0.020
- Trades: sharpeRatio=0.9650, averageMAE=-138.8205, averageMFE=87.5085, largestMAE=-2037.0, largestMFE=456.75, maximumIntraTradeDrawdown=-2142.0

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 24 | 1803.60 | 75.15 | 100.0% | 12.0 | 29.5 | 61.09 | 1 | -2037.00 | 105.60 | 3.32 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 21 | 1319.50 | 62.83 | 100.0% | 13.2 | 8.2 | 161.34 | 0 | -375.70 | 78.75 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 25 | 939.20 | 37.57 | 100.0% | 4.1 | 7.3 | 128.20 | 0 | -1137.30 | 42.50 | 2.40 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 4 | 939.10 | 234.77 | 100.0% | 14.5 | 1.6 | 582.99 | 0 | -346.80 | 293.60 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 7 | 585.40 | 83.63 | 100.0% | 14.0 | 3.3 | 178.63 | 0 | -290.70 | 61.25 | 40.12 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 | 0.2 | 845.57 | 0 | -76.50 | 243.10 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 4 | 113.80 | 28.45 | 100.0% | 14.4 | 1.3 | 86.76 | 0 | -103.50 | 29.70 | 4.00 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 69.00 | 34.50 | 100.0% | 52.6 | 1.8 | 39.37 | 0 | -243.10 | 60.52 | 6.00 |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 24 | 51.96 | 6.29 | 46.83 | 26.85 | 73.8 | 1 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 21 | 67.84 | 5.61 | 70.24 | 34.46 | 23.4 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 25 | 65.88 | 29.56 | 46.72 | 25.92 | 17.6 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 4 | 75.70 | 17.25 | 63.63 | 22.37 | 24.2 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 7 | 66.14 | 10.47 | 66.82 | 25.28 | 28.1 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 76.66 | 7.38 | 81.57 | 36.81 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 4 | 53.10 | 6.33 | 49.47 | 22.70 | 19.7 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 82.95 | 11.24 | 80.45 | 36.67 | 52.6 | 0 |
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
- MAE: average -140.42, median -68.25, worst -2037.00
- MFE: average 87.51, median 60.38, best 456.75
- Average MFE / absolute MAE: 0.62

## Intratrade Path
- Trades with path stats: 88; with intratrade price samples: 88
- Went positive before max adverse: 50.0%
- MFE happened before MAE: 11.4%
- TP touched before MAE: 2.3%
- Median MFE available before MAE: 0.03 points
- Median first TP touch: 3.9 minutes
- Median first +1.5 points: 2.9 minutes
- First 15m MFE/MAE medians: 2.40 / -1.92 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-30T19:16:02+00:00` -> `2026-07-01T15:15:11+00:00`.
- Strategy/profile: `pullback_long` / `pullback_long`. PnL 35.00, MAE -2037.00, MFE 105.00, hold 1199.2 minutes.
- Profile context: `pullback_long` produced 24 trades, PnL 1803.60, 1 slow >=12h trades, and 30.2% of total PnL.
- Entry state: setup=41.65, ES-VWAP=6.91, VWAP slope=0.0008, VWAP acceleration=-0.0006, RSI=42.87, ADX=12.32, structure score=4.00, higher-low=1.00, higher-high=-1.00, pullback-from-high=2.50, rolling-high distance=3.50.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=5.00, slow-risk points=0.00.
- Existing warning reason: setup quality 41.65 <= 50.00; ES structure higher-high -1.00 < 0.00; RSI slope -2.7354 <= -2.0000; ADX 12.32 <= 18.00; RSI 42.87 <= 45.00.
- Strategy selection reason: VALID_0DTE ordered router; ordered ES pullback: trendPrice=7544.00, ema=7544.63, distance=6.91, adx=12.32, rsi=42.87, structure=4.
- Intratrade path: path MFE 2.80, path MAE -58.20, MFE before MAE=`True`, TP reached=`False`.
- Surgical setup floor check: `setup_quality_score >= 41.7` would block this trade, keep 87 trades, retain 99.4% PnL, and leave worst MAE -1137.30. It would block 1 trades total.
- Candidate guards that would have blocked this tail:
  - `setup_quality_score >= 45`: kept 85 trades, retained 96.1% PnL, kept worst MAE -1137.30.
  - `option_strike_map_target_3_distance >= 2`: kept 78 trades, retained 89.9% PnL, kept worst MAE -1137.30.
  - `setup_quality_score >= 50`: kept 78 trades, retained 88.5% PnL, kept worst MAE -1137.30.

## Unscanned Feature Coverage
- Present trade columns: 144, scanned columns: 144, unscanned columns: 0
- No unscanned feature columns found. Good coverage for all present trade fields.

## Candidate Entry Quality Filters

| Scope | Condition | Kept | Blocked | Kept PnL | PnL Loss | Retained PnL | Slow Removed | Slow Left | Kept PnL/Exposure Hr | Kept Worst MAE | Score |
| --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| all_trades | `setup_quality_score >= 45` | 85 | 3 | 5742.80 | 234.20 | 96.1% | 1 | 0 | 177.98 | -1137.30 | 131.4 |
| all_trades | `option_strike_map_target_3_distance >= 2` | 78 | 10 | 5373.80 | 603.20 | 89.9% | 1 | 0 | 181.33 | -1137.30 | 63.9 |
| all_trades | `setup_quality_score >= 50` | 78 | 10 | 5287.00 | 690.00 | 88.5% | 1 | 0 | 185.20 | -1137.30 | 48.3 |
| all_trades | `rsi_slope >= -0.5` | 64 | 24 | 4530.00 | 1447.00 | 75.8% | 1 | 0 | 210.54 | -392.00 | -45.4 |
| all_trades | `rsi_slope >= 0` | 62 | 26 | 4452.50 | 1524.50 | 74.5% | 1 | 0 | 211.58 | -392.00 | -59.6 |
| all_trades | `option_strike_map_target_3_distance >= 3` | 63 | 25 | 4641.30 | 1335.70 | 77.7% | 1 | 0 | 218.24 | -1137.30 | -70.2 |
| all_trades | `rsi_slope >= 0.25` | 56 | 32 | 4101.70 | 1875.30 | 68.6% | 1 | 0 | 218.53 | -392.00 | -123.7 |
| all_trades | `setup_quality_score >= 55` | 66 | 22 | 4296.80 | 1680.20 | 71.9% | 1 | 0 | 167.50 | -1137.30 | -131.8 |
| all_trades | `rsi_slope >= 0.5` | 53 | 35 | 3978.10 | 1998.90 | 66.6% | 1 | 0 | 217.80 | -392.00 | -146.4 |
| all_trades | `rsi_slope >= 0.75` | 51 | 37 | 3908.10 | 2068.90 | 65.4% | 1 | 0 | 234.60 | -392.00 | -159.3 |

## Hidden MAE Signature Candidates

| Condition | Bad Trades | Bad Blocked | Good Blocked | Kept Trades | Kept PnL | PnL Loss | Retained PnL | Kept Worst MAE | Score |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| `entry_veto_reason != "no entry-veto points"` | 17 | 4 | 0 | 84 | 5831.00 | 146.00 | 97.6% | -2037.00 | 49184.2 |
| `long_strategy != "breakout_long_1dte"` | 17 | 6 | 15 | 67 | 4657.50 | 1319.50 | 77.9% | -2037.00 | 49017.1 |
| `strategy_profile != "breakout_long_1dte"` | 17 | 6 | 15 | 67 | 4657.50 | 1319.50 | 77.9% | -2037.00 | 49017.1 |
| `es_structure_score <= 4` | 17 | 7 | 17 | 64 | 4598.90 | 1378.10 | 76.9% | -2037.00 | 302.9 |
| `path_effective_tp_distance >= 2.8` | 17 | 7 | 31 | 50 | 4238.70 | 1738.30 | 70.9% | -2037.00 | 217.1 |
| `option_strike_map_next_upside_call_volume_distance >= 3.25` | 17 | 6 | 21 | 61 | 4586.90 | 1390.10 | 76.7% | -1137.30 | 212.4 |
| `es_vwap_acceleration >= -0.000550314` | 17 | 5 | 15 | 68 | 4868.80 | 1108.20 | 81.5% | -2037.00 | 189.8 |
| `option_strike_map_atm_strike <= 7540` | 17 | 5 | 12 | 71 | 4815.90 | 1161.10 | 80.6% | -1137.30 | 184.8 |
| `es_vwap_acceleration >= -0.00322863` | 17 | 4 | 11 | 73 | 5178.00 | 799.00 | 86.6% | -2037.00 | 169.1 |
| `option_strike_map_next_upside_call_volume_distance >= 2.5` | 17 | 4 | 11 | 73 | 5129.70 | 847.30 | 85.8% | -1137.30 | 160.4 |
| `es_higher_low_distance >= 2.25` | 17 | 6 | 27 | 55 | 4311.40 | 1665.60 | 72.1% | -392.00 | 153.8 |
| `option_strike_map_underlying_price <= 7539.75` | 17 | 5 | 18 | 65 | 4651.50 | 1325.50 | 77.8% | -1137.30 | 146.2 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 29169
- position_wait: 15110
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1244
- waiting_spx_quote: 415
- trade_risk_tighten_signal: 409
- order_event: 402
- entry_signal: 89

## Blocked Gate Counts
- setup_quality_allowed: 10309 (disabled=10309)
- above_vwap_confirmed: 7586 (disabled=7586)
- above_vwap: 6759 (disabled=6759)
- es_structure_allowed: 6579 (disabled=6579)
- pullback: 5366 (disabled=5366)
- momentum: 3348 (disabled=3348)
- es_vwap_max_distance_allowed: 3325 (disabled=3325)
- es_vwap_slope_allowed: 2897 (disabled=2897)
- es_vwap_acceleration_allowed: 1542 (disabled=1542)
- trend_strength: 1260 (disabled=1260)
- es_rolling_high_allowed: 417 (disabled=417)
- indicator_slope_allowed: 346 (disabled=346)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 8 | 10 | 1219.70 | 121.97 | 100.0% | 16.5 |
| 13 | 9 | 337.60 | 37.51 | 100.0% | 0.4 |
| 12 | 7 | 333.50 | 47.64 | 100.0% | 12.7 |
| 1 | 6 | 429.50 | 71.58 | 100.0% | 7.0 |
| 11 | 5 | 202.30 | 40.46 | 100.0% | 11.9 |
| 19 | 5 | 190.10 | 38.02 | 100.0% | 17.0 |
| 5 | 5 | 380.80 | 76.16 | 100.0% | 10.2 |
| 0 | 4 | 279.80 | 69.95 | 100.0% | 9.0 |
| 14 | 4 | 549.20 | 137.30 | 100.0% | 5.3 |
| 2 | 4 | 210.40 | 52.60 | 100.0% | 48.6 |
| 22 | 4 | 389.80 | 97.45 | 100.0% | 14.9 |
| 6 | 4 | 201.10 | 50.28 | 100.0% | 14.2 |
| 9 | 4 | 176.90 | 44.22 | 100.0% | 17.6 |
| 15 | 3 | 269.50 | 89.83 | 100.0% | 6.5 |
| 18 | 3 | 201.30 | 67.10 | 100.0% | 8.7 |
| 7 | 3 | 208.40 | 69.47 | 100.0% | 12.0 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 147.40 | 73.70 | 100.0% | 15.9 |
| 10 | 1 | 35.00 | 35.00 | 100.0% | 14.0 |
| 16 | 1 | 40.80 | 40.80 | 100.0% | 4.1 |
| 17 | 1 | 80.50 | 80.50 | 100.0% | 12.0 |
| 4 | 1 | 23.40 | 23.40 | 100.0% | 12.5 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 42 | 2272.30 | 54.10 | 100.0% | 9.7 |
| 55-60 | 14 | 1414.80 | 101.06 | 100.0% | 12.0 |
| >=75 | 12 | 1056.30 | 88.02 | 100.0% | 10.9 |
| 65-70 | 9 | 681.00 | 75.67 | 100.0% | 24.9 |
| 60-65 | 7 | 337.40 | 48.20 | 100.0% | 25.7 |
| 70-75 | 4 | 215.20 | 53.80 | 100.0% | 21.6 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 25-30 | 24 | 1243.10 | 51.80 | 100.0% | 9.2 |
| 20-25 | 19 | 1138.30 | 59.91 | 100.0% | 12.0 |
| 30-40 | 18 | 1504.80 | 83.60 | 100.0% | 13.4 |
| <20 | 13 | 1194.90 | 91.92 | 100.0% | 12.5 |
| 40-50 | 10 | 622.20 | 62.22 | 100.0% | 12.6 |
| >=50 | 4 | 273.70 | 68.42 | 100.0% | 14.5 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 88 | 5977.00 | 67.92 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 83 | 5346.60 | 64.42 | 100.0% | 12.0 |
| 0.25-0.5 | 4 | 595.40 | 148.85 | 100.0% | 12.8 |
| -0.25-0 | 1 | 35.00 | 35.00 | 100.0% | 56.6 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 46 | 3250.00 | 70.65 | 100.0% | 12.0 |
| -0.05-0 | 26 | 1384.10 | 53.23 | 100.0% | 12.0 |
| 0.1-0.25 | 7 | 899.00 | 128.43 | 100.0% | 14.7 |
| 0.05-0.1 | 6 | 286.40 | 47.73 | 100.0% | 21.9 |
| >=0.25 | 2 | 70.00 | 35.00 | 100.0% | 49.0 |
| -0.1--0.05 | 1 | 87.50 | 87.50 | 100.0% | 9.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 21 | 917.00 | 43.67 | 100.0% | 8.5 |
| 0-1 | 20 | 1852.40 | 92.62 | 100.0% | 13.9 |
| 2-4 | 16 | 858.60 | 53.66 | 100.0% | 15.7 |
| 6-8 | 10 | 860.20 | 86.02 | 100.0% | 12.2 |
| 12-20 | 7 | 577.30 | 82.47 | 100.0% | 6.0 |
| 1-2 | 6 | 383.10 | 63.85 | 100.0% | 17.9 |
| 8-12 | 6 | 458.40 | 76.40 | 100.0% | 12.0 |
| >=20 | 2 | 70.00 | 35.00 | 100.0% | 37.8 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 34 | 2079.80 | 61.17 | 100.0% | 12.0 |
| <1 | 23 | 2033.60 | 88.42 | 100.0% | 14.7 |
| 10-20 | 11 | 511.90 | 46.54 | 100.0% | 12.5 |
| 1-3 | 9 | 863.50 | 95.94 | 100.0% | 9.4 |
| 3-5 | 7 | 349.70 | 49.96 | 100.0% | 11.9 |
| 5-10 | 4 | 138.50 | 34.62 | 100.0% | 16.8 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 31 | 2312.10 | 74.58 | 100.0% | 12.7 |
| 0-1 | 17 | 860.60 | 50.62 | 100.0% | 6.6 |
| -2--1 | 9 | 325.30 | 36.14 | 100.0% | 12.5 |
| 1-2 | 7 | 594.70 | 84.96 | 100.0% | 12.0 |
| 2-3 | 7 | 685.10 | 97.87 | 100.0% | 12.0 |
| <-3 | 7 | 360.00 | 51.43 | 100.0% | 11.9 |
| -3--2 | 4 | 157.90 | 39.48 | 100.0% | 62.2 |
| -1-0 | 3 | 515.00 | 171.67 | 100.0% | 25.7 |
| missing | 3 | 166.30 | 55.43 | 100.0% | 8.5 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 23 | 1333.40 | 57.97 | 100.0% | 12.4 |
| -1-0 | 18 | 1124.00 | 62.44 | 100.0% | 13.0 |
| -2--1 | 17 | 1270.50 | 74.74 | 100.0% | 17.3 |
| 1-2 | 17 | 1044.30 | 61.43 | 100.0% | 2.6 |
| 2-3 | 8 | 983.10 | 122.89 | 100.0% | 10.8 |
| missing | 3 | 166.30 | 55.43 | 100.0% | 8.5 |
| -3--2 | 2 | 55.40 | 27.70 | 100.0% | 83.7 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 25 | 1389.10 | 55.56 | 100.0% | 12.7 |
| 4-8 | 23 | 2081.00 | 90.48 | 100.0% | 12.0 |
| 1-2 | 19 | 895.00 | 47.11 | 100.0% | 12.0 |
| >=8 | 12 | 1108.90 | 92.41 | 100.0% | 16.5 |
| 0-0.5 | 5 | 196.00 | 39.20 | 100.0% | 11.9 |
| 0.5-1 | 4 | 307.00 | 76.75 | 100.0% | 30.0 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 32 | 2341.30 | 73.17 | 100.0% | 12.4 |
| 3 | 30 | 1923.40 | 64.11 | 100.0% | 12.0 |
| 5 | 24 | 1378.10 | 57.42 | 100.0% | 12.1 |
| 2 | 2 | 334.20 | 167.10 | 100.0% | 12.0 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 43 | 3379.40 | 78.59 | 100.0% | 13.2 |
| 2-4 | 22 | 1081.00 | 49.14 | 100.0% | 11.9 |
| 4-8 | 19 | 1323.70 | 69.67 | 100.0% | 12.0 |
| 8-12 | 3 | 105.40 | 35.13 | 100.0% | 12.0 |
| 12-16 | 1 | 87.50 | 87.50 | 100.0% | 9.7 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 34 | 2312.90 | 68.03 | 100.0% | 12.3 |
| 1-2 | 13 | 830.30 | 63.87 | 100.0% | 12.0 |
| 2-4 | 12 | 522.60 | 43.55 | 100.0% | 32.4 |
| 4-8 | 10 | 538.90 | 53.89 | 100.0% | 6.4 |
| 0.5-1 | 9 | 768.50 | 85.39 | 100.0% | 3.1 |
| 0-0.5 | 6 | 377.60 | 62.93 | 100.0% | 11.1 |
| >=8 | 4 | 626.20 | 156.55 | 100.0% | 17.6 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 34 | 2070.00 | 60.88 | 100.0% | 11.1 |
| 1-2 | 13 | 716.10 | 55.08 | 100.0% | 20.0 |
| 2-4 | 12 | 957.40 | 79.78 | 100.0% | 12.1 |
| 4-8 | 12 | 1135.00 | 94.58 | 100.0% | 12.6 |
| 0-0.5 | 7 | 528.90 | 75.56 | 100.0% | 16.4 |
| >=8 | 7 | 454.20 | 64.89 | 100.0% | 16.1 |
| 0.5-1 | 3 | 115.40 | 38.47 | 100.0% | 12.0 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 35 | 2283.70 | 65.25 | 100.0% | 14.7 |
| >=24 | 20 | 732.70 | 36.64 | 100.0% | 2.7 |
| 8-12 | 11 | 1328.60 | 120.78 | 100.0% | 23.3 |
| 2-4 | 8 | 563.70 | 70.46 | 100.0% | 15.7 |
| 12-16 | 6 | 334.30 | 55.72 | 100.0% | 13.0 |
| 16-24 | 5 | 556.00 | 111.20 | 100.0% | 9.4 |
| 0-2 | 3 | 178.00 | 59.33 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 60-70 | 27 | 1602.60 | 59.36 | 100.0% | 9.9 |
| 50-60 | 25 | 1899.70 | 75.99 | 100.0% | 12.0 |
| 70-80 | 15 | 840.10 | 56.01 | 100.0% | 12.1 |
| 80-90 | 11 | 944.60 | 85.87 | 100.0% | 16.9 |
| 40-50 | 10 | 690.00 | 69.00 | 100.0% | 12.3 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 29 | 1922.50 | 66.29 | 100.0% | 13.2 |
| 4-5 | 19 | 1483.50 | 78.08 | 100.0% | 8.7 |
| 3-4 | 14 | 894.90 | 63.92 | 100.0% | 11.9 |
| 2-3 | 13 | 1009.70 | 77.67 | 100.0% | 12.0 |
| 5-6 | 9 | 520.40 | 57.82 | 100.0% | 12.0 |
| <1 | 4 | 146.00 | 36.50 | 100.0% | 29.7 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 88 | 5977.00 | 67.92 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 88 | 5977.00 | 67.92 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 35 | 2283.70 | 65.25 | 100.0% | 14.7 |
| >=24 | 20 | 732.70 | 36.64 | 100.0% | 2.7 |
| 8-12 | 11 | 1328.60 | 120.78 | 100.0% | 23.3 |
| 2-4 | 8 | 563.70 | 70.46 | 100.0% | 15.7 |
| 12-16 | 6 | 334.30 | 55.72 | 100.0% | 13.0 |
| 16-24 | 5 | 556.00 | 111.20 | 100.0% | 9.4 |
| 0-2 | 3 | 178.00 | 59.33 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 54 | 3276.60 | 60.68 | 100.0% | 9.9 |
| 2-4 | 12 | 649.40 | 54.12 | 100.0% | 19.9 |
| 4-6 | 9 | 680.70 | 75.63 | 100.0% | 9.9 |
| 1-2 | 5 | 414.00 | 82.80 | 100.0% | 32.1 |
| 8-12 | 4 | 818.30 | 204.57 | 100.0% | 13.4 |
| >=12 | 3 | 103.00 | 34.33 | 100.0% | 23.3 |
| 6-8 | 1 | 35.00 | 35.00 | 100.0% | 16.1 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 32 | 2863.40 | 89.48 | 100.0% | 12.0 |
| <5 | 22 | 1499.40 | 68.15 | 100.0% | 1.8 |
| 15-30 | 17 | 555.50 | 32.68 | 100.0% | 20.0 |
| 60-180 | 9 | 313.00 | 34.78 | 100.0% | 104.7 |
| 30-60 | 7 | 710.70 | 101.53 | 100.0% | 38.0 |
| >=720 | 1 | 35.00 | 35.00 | 100.0% | 1199.2 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 88 | 5977.00 | 67.92 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 60 | 4267.30 | 71.12 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 21 | 1319.50 | 62.83 | 100.0% | 13.2 |
| STALE_0DTE | 6 | 182.80 | 30.47 | 100.0% | 19.8 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 60 | 4267.30 | 71.12 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 21 | 1319.50 | 62.83 | 100.0% | 13.2 |
| STALE_0DTE | 6 | 182.80 | 30.47 | 100.0% | 19.8 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 55 | 3845.20 | 69.91 | 12.0 | 17.7 | 216.92 | 0 |
| 2026-07 | 33 | 2131.80 | 64.60 | 13.2 | 35.5 | 60.05 | 1 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 6.8 |
| 2.40 | 25 | 939.20 | 37.57 | 4.1 |
| 2.64 | 1 | 97.20 | 97.20 | 5.4 |
| 2.81 | 1 | 39.60 | 39.60 | 12.0 |
| 2.86 | 1 | 35.00 | 35.00 | 56.6 |
| 3.00 | 21 | 1319.50 | 62.83 | 13.2 |
| 3.06 | 1 | 108.50 | 108.50 | 8.5 |
| 3.11 | 2 | 223.70 | 111.85 | 8.1 |
| 3.13 | 1 | 115.20 | 115.20 | 51.5 |
| 3.16 | 1 | 35.00 | 35.00 | 1199.2 |
| 3.19 | 2 | 90.40 | 45.20 | 51.0 |
| 3.23 | 1 | 35.00 | 35.00 | 26.0 |
| 3.30 | 1 | 119.00 | 119.00 | 6.6 |
| 3.33 | 2 | 154.00 | 77.00 | 16.9 |
| 3.38 | 1 | 34.00 | 34.00 | 15.3 |
| 3.40 | 2 | 70.00 | 35.00 | 87.3 |
| 3.51 | 1 | 46.80 | 46.80 | 12.7 |
| 3.55 | 1 | 129.60 | 129.60 | 10.2 |
| 3.60 | 5 | 441.00 | 88.20 | 12.0 |
| 4.00 | 3 | 59.40 | 19.80 | 16.4 |
| 4.69 | 1 | 34.00 | 34.00 | 104.7 |
| 6.00 | 3 | 276.40 | 92.13 | 23.3 |
| 12.00 | 4 | 939.10 | 234.77 | 14.5 |
| 13.44 | 1 | 61.20 | 61.20 | 12.0 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 40.12 | 1 | 273.00 | 273.00 | 12.0 |
| 41.94 | 1 | 35.00 | 35.00 | 16.1 |
| 48.62 | 2 | 70.00 | 35.00 | 19.9 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 1 (1.1%)
- Slow-trade median hold: 1199.2 minutes
- Slow-trade total PnL: 35.00
- rsi14: slow median 42.87, fast<15m median 52.00
- adx14: slow median 12.32, fast<15m median 26.19
- es_minus_vwap: slow median 6.91, fast<15m median 9.52
- price_minus_ema20: slow median -22.63, fast<15m median -57.26
- es_structure_score: slow median 4.00, fast<15m median 4.00
- es_structure_pullback_from_high: slow median 2.50, fast<15m median 2.00
- es_structure_higher_low_distance: slow median 1.00, fast<15m median 0.75
- es_structure_higher_high_distance: slow median -1.00, fast<15m median 0.25
- es_structure_vwap_distance: slow median 6.91, fast<15m median 9.52
- es_vwap_acceleration: slow median -0.00, fast<15m median 0.00
- es_rolling_high_distance: slow median 3.50, fast<15m median 4.62
- es_rolling_high_minutes_since: slow median 14.93, fast<15m median 10.40
- rsi_slope: slow median -2.74, fast<15m median 1.63
- adx_slope: slow median -0.91, fast<15m median 0.62
- setup_quality_score: slow median 41.65, fast<15m median 60.87
- setup_quality_take_profit_boost: slow median 0.00, fast<15m median 0.05
- entry_veto_points: slow median 5.00, fast<15m median 3.00
- slow_risk_points: slow median 0.00, fast<15m median 0.00
- es_reclaim_current_distance: slow median 6.91, fast<15m median 9.52
- spx_ema20_distance: slow median -0.63, fast<15m median -0.23

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
